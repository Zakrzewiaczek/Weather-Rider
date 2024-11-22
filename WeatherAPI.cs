using System.Diagnostics;
using System.Globalization;
using System.Xml.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Weather_Rider
{
    public struct Place(double lat, double lon)
    {
        public readonly double Lat => lat;
        public readonly double Lon => lon;

        public string? Name { get; set; }
        public string? ID { get; set; }
        public string? CountryCode { get; set; }
        public string? FeatureCode { get; set; }
    }


    /// <summary>
    /// Exception thrown when the server returns an error request.
    /// </summary>
    public class HttpSenderErrorException : Exception
    {
        public HttpSenderErrorException() { }
        public HttpSenderErrorException(string? message) : base(message) { }
        public HttpSenderErrorException(string? message, Exception inner) : base(message, inner) { }
    }
    public class PlaceNotFound : Exception
    {
        public PlaceNotFound() { }
        public PlaceNotFound(string? message) : base(message) { }
        public PlaceNotFound(string? message, Exception inner) : base(message, inner) { }
    }


    /*
     * 
     * https://open-meteo.com/en/docs#current=&hourly=&daily=&forecast_days=1
     * https://open-meteo.com/en/docs/air-quality-api#latitude=52.1658&longitude=20.9671&current=pm10,pm2_5,carbon_monoxide,nitrogen_dioxide,sulphur_dioxide,ozone,aerosol_optical_depth,dust,ammonia,alder_pollen,birch_pollen,grass_pollen,mugwort_pollen,olive_pollen,ragweed_pollen&hourly=&timezone=Europe%2FBerlin&forecast_days=1&domains=cams_europe
     * 
     */

    public class WeatherAPI(Place place)
    {
        public Place Place { get => place; set => place = value; }

        private readonly Dictionary<string, string> units = [];
        public Dictionary<string, (object data, string unit)> AllData => allData;
        private readonly Dictionary<string, (object data, string unit)> allData = [];


        public void Update()
        {
            (string weatherData, string aqiData) = HttpRequest();

            JObject weatherJson = JObject.Parse(weatherData);
            JObject aqiJson = JObject.Parse(aqiData);

            DateTime nearestDate = DateTime.Now;
            #region [...]

            int najblizszeMinuty = ((nearestDate.Minute + 7) / 15) * 15;
            if (najblizszeMinuty >= 60)
            {
                nearestDate = nearestDate.AddHours(1);
                najblizszeMinuty = 0;
            }

            nearestDate = new DateTime(nearestDate.Year, nearestDate.Month, nearestDate.Day, nearestDate.Hour, najblizszeMinuty, 0);


            #endregion


            string[] listNames = ["hourly", "minutely_15", "daily"];
            units.Clear();
            allData.Clear();

            for(int index = 0; index < listNames.Length; index++)
            {
                AddUnits(weatherJson, listNames[index]);
                AddData(weatherJson, listNames[index], allData, nearestDate);
            }
            AddUnits(aqiJson, listNames[0]);
            AddData(aqiJson, listNames[0], allData, nearestDate);
        }


        private void AddUnits(JObject json, string unitKey)
        {
            var currentUnits = json[$"{unitKey}_units"]?.ToObject<Dictionary<string, string>>() ?? [];
            foreach (var unit in currentUnits)
                units.TryAdd(unit.Key, unit.Value);
        }
        private void AddData(JObject json, string dataKey, Dictionary<string, (object data, string unit)> dataDict, DateTime nearestTime)
        {
            // Checking errors
            if (json["error"]?.ToString() != null)
                throw new HttpSenderErrorException(json["reason"]?.ToString());
            

            json = json[dataKey]?.ToObject<JObject>() ?? [];
            var times = json["time"]?.ToObject<List<DateTime>>() ?? [];
            int timeIndex;
            #region [...]

            if (times.Count == 0)
                throw new Exception("No data found");
            else if (times.Count == 1)
                timeIndex = 0;
            else if (times.Count <= 24)
                timeIndex = times.IndexOf(new DateTime(nearestTime.Year, nearestTime.Month, nearestTime.Day, nearestTime.Hour, 0, 0));
            else
                timeIndex = times.IndexOf(new DateTime(nearestTime.Year, nearestTime.Month, nearestTime.Day, 0, 0, 0));

            #endregion

            foreach (var data in json)
            {
                if (data.Key == "time") continue;
                
                JArray? array = data.Value as JArray;
                // Jeżeli System.ArgumentOutOfRangeException (timeIndex = -1) to może być w pliku zła data
                dataDict.TryAdd(data.Key, (array?[timeIndex]?.ToString() ?? "null", units[data.Key] ?? "null"));
            }
        }
        private (string, string) HttpRequest()
        {
            Debug.WriteLine("HttpRequest variables initializing...");
            #region All uri data

            List<string> requestParams =
            [
                $"latitude={place.Lat.ToString(CultureInfo.InvariantCulture)}",
                $"longitude={place.Lon.ToString(CultureInfo.InvariantCulture)}",
                $"timezone={GlobalSettings.Default.TimeZone.Replace("/", "%2F")}",
                GlobalSettings.Default.TemperatureUnit == "F" ? "temperature_unit=fahrenheit" : string.Empty,
                $"wind_speed_unit={GlobalSettings.Default.WindSpeedUnit.Replace("/", "")}",
                $"precipitation_unit={GlobalSettings.Default.PrecipationUnit}",
                $"forecast_days=1",

                $"minutely_15=temperature_2m,relative_humidity_2m,dew_point_2m,apparent_temperature,precipitation,rain,snowfall,snowfall_height,freezing_level_height,wind_speed_10m,wind_speed_80m,wind_direction_10m,wind_direction_80m,wind_gusts_10m,visibility,lightning_potential,shortwave_radiation_instant,direct_radiation_instant,diffuse_radiation_instant,direct_normal_irradiance_instant,global_tilted_irradiance_instant,terrestrial_radiation_instant,cape",
                $"hourly=precipitation_probability,snow_depth,pressure_msl,surface_pressure,cloud_cover,cloud_cover_low,cloud_cover_mid,cloud_cover_high,evapotranspiration,et0_fao_evapotranspiration,vapour_pressure_deficit,soil_temperature_0cm,soil_temperature_6cm,soil_temperature_18cm,soil_temperature_54cm,soil_moisture_0_to_1cm,soil_moisture_1_to_3cm,soil_moisture_3_to_9cm,soil_moisture_9_to_27cm,soil_moisture_27_to_81cm,temperature_1000hPa,temperature_975hPa,temperature_950hPa,temperature_925hPa,temperature_900hPa,temperature_850hPa,temperature_800hPa,temperature_700hPa,temperature_600hPa,temperature_500hPa,temperature_400hPa,temperature_300hPa,temperature_250hPa,temperature_200hPa,temperature_150hPa,temperature_100hPa,temperature_70hPa,temperature_50hPa,temperature_30hPa,relative_humidity_1000hPa,relative_humidity_975hPa,relative_humidity_950hPa,relative_humidity_925hPa,relative_humidity_900hPa,relative_humidity_850hPa,relative_humidity_800hPa,relative_humidity_700hPa,relative_humidity_600hPa,relative_humidity_500hPa,relative_humidity_400hPa,relative_humidity_300hPa,relative_humidity_250hPa,relative_humidity_200hPa,relative_humidity_150hPa,relative_humidity_100hPa,relative_humidity_70hPa,relative_humidity_50hPa,relative_humidity_30hPa,cloud_cover_1000hPa,cloud_cover_975hPa,cloud_cover_950hPa,cloud_cover_925hPa,cloud_cover_900hPa,cloud_cover_850hPa,cloud_cover_800hPa,cloud_cover_700hPa,cloud_cover_600hPa,cloud_cover_500hPa,cloud_cover_400hPa,cloud_cover_300hPa,cloud_cover_250hPa,cloud_cover_200hPa,cloud_cover_150hPa,cloud_cover_100hPa,cloud_cover_70hPa,cloud_cover_50hPa,cloud_cover_30hPa,wind_speed_1000hPa,wind_speed_975hPa,wind_speed_950hPa,wind_speed_925hPa,wind_speed_900hPa,wind_speed_850hPa,wind_speed_800hPa,wind_speed_700hPa,wind_speed_600hPa,wind_speed_500hPa,wind_speed_400hPa,wind_speed_300hPa,wind_speed_250hPa,wind_speed_200hPa,wind_speed_150hPa,wind_speed_100hPa,wind_speed_70hPa,wind_speed_50hPa,wind_speed_30hPa,wind_direction_1000hPa,wind_direction_975hPa,wind_direction_950hPa,wind_direction_925hPa,wind_direction_900hPa,wind_direction_850hPa,wind_direction_800hPa,wind_direction_700hPa,wind_direction_600hPa,wind_direction_500hPa,wind_direction_400hPa,wind_direction_300hPa,wind_direction_250hPa,wind_direction_200hPa,wind_direction_150hPa,wind_direction_100hPa,wind_direction_70hPa,wind_direction_50hPa,wind_direction_30hPa,uv_index,uv_index_clear_sky,wet_bulb_temperature_2m,total_column_integrated_water_vapour,convective_inhibition,boundary_layer_height",
                $"daily=temperature_2m_max,temperature_2m_min,apparent_temperature_max,apparent_temperature_min,sunrise,sunset,daylight_duration,rain_sum,showers_sum,snowfall_sum,wind_speed_10m_max,wind_gusts_10m_max,wind_direction_10m_dominant,shortwave_radiation_sum,sunshine_duration",
            ];
            List<string> aqiDataParams = 
            [
                $"latitude={place.Lat.ToString(CultureInfo.InvariantCulture)}",
                $"longitude={place.Lon.ToString(CultureInfo.InvariantCulture)}",
                $"timezone={GlobalSettings.Default.TimeZone.Replace("/", "%2F")}",
                $"forecast_days=1",
                $"domains=cams_europe",
                $"hourly=pm10,pm2_5,carbon_monoxide,carbon_dioxide,nitrogen_dioxide,sulphur_dioxide,ozone,aerosol_optical_depth,dust,ammonia,methane,alder_pollen,birch_pollen,grass_pollen,mugwort_pollen,olive_pollen,ragweed_pollen"
            ];
            requestParams.RemoveAll(string.IsNullOrEmpty);
            aqiDataParams.RemoveAll(string.IsNullOrEmpty);

            #endregion

            string weatherDataURI = @"https://api.open-meteo.com/v1/forecast?" + string.Join("&", requestParams);
            string aqiDataURI = $"https://air-quality-api.open-meteo.com/v1/air-quality?" + string.Join("&", aqiDataParams);

            string downloadedWeatherData = string.Empty, downloadedAQIData = string.Empty;

            Debug.WriteLine("URI to download data from server: ");
            Debug.WriteLine("weather: " + weatherDataURI);
            Debug.WriteLine("aqi: " + aqiDataURI);
            Debug.WriteLine("Downloading data from server: ");
            /*using (HttpClient client = new())
            {
                Task weatherDataDownloading = Task.Run(async () =>
                {
                    Debug.WriteLine("weather data downloading");
                    downloadedWeatherData = await client.GetStringAsync(new Uri(weatherDataURI));
                    Debug.WriteLine("weather data downloading OK");
                });
                Task aqiDataDownloading = Task.Run(async () =>
                {
                    Debug.WriteLine("aqi data downloading");
                    downloadedAQIData = await client.GetStringAsync(new Uri(aqiDataURI));
                    Debug.WriteLine("aqi data downloading OK");
                });

                Task.WaitAll(weatherDataDownloading, aqiDataDownloading);
            }*/

            downloadedWeatherData = File.ReadAllText("weather.txt");
            downloadedAQIData = File.ReadAllText("aqi.txt");

            Debug.WriteLine("All data downloaded");
            return (downloadedWeatherData, downloadedAQIData);
        }

        public static Place GetPlaceByName(string name)
        {
            string uri = $"https://geocoding-api.open-meteo.com/v1/search?count=1&language=en&format=json&name={name}";
            string jsonData = string.Empty;

            using (HttpClient client = new())
            {
                Task.Run(async () =>
                {
                    Debug.WriteLine("Place data downloading");
                    jsonData = await client.GetStringAsync(new Uri(uri));
                    Debug.WriteLine("Place data downloading OK");
                }).Wait();
            }

            JObject json = JObject.Parse(jsonData);

            // Checking if the server returned results
            if (json["results"] == null)
                throw new PlaceNotFound();


            JToken results = json["results"]![0]!;

            Place place = new(
                double.Parse(results["latitude"]!.ToString()),
                double.Parse(results["longitude"]!.ToString())
            )
            {
                Name = results["name"]!.ToString(),
                ID = results["id"]!.ToString(),
                CountryCode = results["country_code"]!.ToString(),
                FeatureCode = results["feature_code"]!.ToString()
            };

            return place;
        }
    }
}
