using System.Diagnostics;
using System.Globalization;

using OpenMeteo;

namespace Weather_Rider
{
    public readonly struct Place(double lat, double lon)
    {
        public double Lat => lat;
        public double Lon => lon;
    }

    /*
     * 
     * https://open-meteo.com/en/docs#current=&hourly=&daily=&forecast_days=1
     * https://open-meteo.com/en/docs/air-quality-api#latitude=52.1658&longitude=20.9671&current=pm10,pm2_5,carbon_monoxide,nitrogen_dioxide,sulphur_dioxide,ozone,aerosol_optical_depth,dust,ammonia,alder_pollen,birch_pollen,grass_pollen,mugwort_pollen,olive_pollen,ragweed_pollen&hourly=&timezone=Europe%2FBerlin&forecast_days=1&domains=cams_europe
     * 
     */

    public class WeatherAPI()
    {
        private Place place;
        public Place Place { get => place; set => place = value; }


        public string HttpRequest()
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
                $"",
            ];
            List<string> aqiDataParams = 
            [
                $"latitude={place.Lat.ToString(CultureInfo.InvariantCulture)}",
                $"longitude={place.Lon.ToString(CultureInfo.InvariantCulture)}",
                $"timezone={GlobalSettings.Default.TimeZone.Replace("/", "%2F")}",
                $"forecast_days=1",
                $"domains=cams_europe",
                $"current=pm10,pm2_5,carbon_monoxide,nitrogen_dioxide,sulphur_dioxide,ozone,aerosol_optical_depth,dust,ammonia,alder_pollen,birch_pollen,grass_pollen,mugwort_pollen,olive_pollen,ragweed_pollen"
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
            using (HttpClient client = new())
            {
                Task weatherDataDownloading = Task.Run(async () =>
                {
                    Debug.Write("weather data downloading");
                    downloadedWeatherData = await client.GetStringAsync(new Uri(weatherDataURI));
                    Debug.WriteLine("weather data downloading OK");
                });
                Task aqiDataDownloading = Task.Run(async () =>
                {
                    Debug.Write("aqi data downloading");
                    downloadedAQIData = await client.GetStringAsync(new Uri(aqiDataURI));
                    Debug.WriteLine("aqi data downloading OK");
                });

                Task.WaitAll(weatherDataDownloading, aqiDataDownloading);
            }

            // Save to files in desktop
            Debug.WriteLine("Saving data to files");
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\weatherData.json", downloadedWeatherData);
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\aqiData.json", downloadedAQIData);

            return string.Empty;
        }
    }
}
