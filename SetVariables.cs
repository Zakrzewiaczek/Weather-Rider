using System;
using System.Drawing;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Weather_Rider.Properties;


namespace Weather_Data
{
    public class SetVariables
    {
        private static Form1 form;
        private static APIData ApiData;
        public SetVariables(Form1 form_obj, APIData apiData)
        {
            form = form_obj;
            ApiData = apiData;
        }

        private int ConvertKmHToBeaufort(double windSpeedKmH)
        {
            int[] windSpeeds = new[] { 1, 6, 12, 20, 29, 39, 50, 62, 75, 89, 103, 118 };

            for (int i = 0; i < windSpeeds.Length; i++)
            {
                if (windSpeedKmH < windSpeeds[i])
                    return i;
            }

            return 12; // Dla prędkości wiatru >= 118 km/h
        }

        public void SetData()
        {
            #region generalData Panel

            string pressure_str = ApiData.GetData("pressure_value_1d");
            string sea_level_pressure_str = ApiData.GetData("sea_level_pressure_value_1d");
            string pressure_tendency = "--";

            if (pressure_str != "--")
                pressure_str = (double.Parse(pressure_str) / 100).ToString();

            if (sea_level_pressure_str != "--")
                sea_level_pressure_str = (double.Parse(sea_level_pressure_str) / 100).ToString();

            #region Label

            form.generalData_data_out.Text =
                $"{ApiData.GetData("air_temp_value_1")} °C\n" +
                $"{ApiData.GetData("soil_temp_1")} °C\n" +
                $"{ApiData.GetData("water_temp_1")} °C\n\n" +
                $"{ApiData.GetData("relative_humidity_value_1")} %\n\n" +
                $"{pressure_str} hPa\n" +
                $"{sea_level_pressure_str} hPa\n" +
                $"{pressure_tendency}\n\n" +
                $"{ApiData.GetData("precip_accum_1")} mm\n";
            #endregion
            #endregion
            #region windData Panel
                                                                           //               _________________________________________
            string wind_speed_str = ApiData.GetData("wind_speed_value_1"); //               |              km/h => mph              |
            string beaufort_wind_speed_str = (wind_speed_str != "--") ? ConvertKmHToBeaufort(double.Parse(wind_speed_str) * 0.621371).ToString() : "--";

            if (wind_speed_str != "--")
            {
                Bitmap icon = (Bitmap)Resources.ResourceManager.GetObject($"scale{beaufort_wind_speed_str}");
                icon = Image.Rotate(icon, new PointF(icon.Width / 2, icon.Height / 2), int.Parse(ApiData.GetData("wind_direction_value_1")) - 55);

                form.windDataPictureBox.BackgroundImage = icon;
            }

            string peak_wind_str = ApiData.GetData("peak_wind_speed_value_1");
            if (peak_wind_str != "--")
                peak_wind_str = (double.Parse(peak_wind_str) / 3.6).ToString();

            string sonic_wind_str = ApiData.GetData("sonic_wind_speed_value_1");
            if (sonic_wind_str != "--")
                sonic_wind_str = (double.Parse(sonic_wind_str) / 3.6).ToString();

            string altimeter_str = ApiData.GetData("altimeter_value_1");
            if (altimeter_str != "--")
                altimeter_str = (double.Parse(altimeter_str) / 100).ToString();

            #region Label

            form.windData_data_out.Text =
                $"{wind_speed_str} km/h\n" +
                $"{((wind_speed_str != "--") ? (double.Parse(wind_speed_str) / 3.6).ToString() : "--")} m/s\n" +
                $"{((wind_speed_str != "--") ? (double.Parse(wind_speed_str) * 0.621371).ToString() : "--")} mph\n" +
                $"{beaufort_wind_speed_str} beaufort\n\n" +
                $"{ApiData.GetData("wind_direction_value_1")}° ({ApiData.GetData("wind_cardinal_direction_value_1d")})\n\n" +
                $"{ApiData.GetData("wind_gust_value_1")} km/h\n" +
                $"{peak_wind_str} m/s\n" +
                $"{sonic_wind_str} m/s\n\n" +
                $"{altimeter_str} hPa";

            #endregion
            #endregion
            #region cloudData Panel

            #region Cloud levels data

            dynamic data_cloud1 = JsonConvert.DeserializeObject("{ \"sky_condition\": \"--\", \"height_agl\": \"--\"}"),
                    data_cloud2 = JsonConvert.DeserializeObject("{ \"sky_condition\": \"--\", \"height_agl\": \"--\"}"),
                    data_cloud3 = JsonConvert.DeserializeObject("{ \"sky_condition\": \"--\", \"height_agl\": \"--\"}");

            string cloud_layer = ApiData.GetData("cloud_layer_1_value_1d").Replace("null", "\"--\"");
            try { data_cloud1 = JsonConvert.DeserializeObject(cloud_layer); } catch (JsonReaderException) { };

            cloud_layer = ApiData.GetData("cloud_layer_2_value_1d").Replace("null", "\"--\"");
            try { data_cloud2 = JsonConvert.DeserializeObject(cloud_layer); } catch (JsonReaderException) { };

            cloud_layer = ApiData.GetData("cloud_layer_3_value_1d").Replace("null", "\"--\"");
            try { data_cloud3 = JsonConvert.DeserializeObject(cloud_layer); } catch (JsonReaderException) { };

            string visiblity_str = ApiData.GetData("visibility_value_1");
            if (visiblity_str != "--")
                visiblity_str = (float.Parse(visiblity_str) * 1609.34).ToString();

            #endregion
            #region Label

            form.cloudData_data_out.Text =
                $"{data_cloud1.sky_condition}, {data_cloud1.height_agl} m ht.\n" +
                $"{data_cloud2.sky_condition}, {data_cloud2.height_agl} m ht.\n" +
                $"{data_cloud3.sky_condition}, {data_cloud3.height_agl} m ht.\n\n" +
                $"{ApiData.GetData("ceiling_value_1")} m\n\n" +
                $"{visiblity_str} m\n\n" +
                $"{ApiData.GetData("weather_condition_value_1d")}\n" +
                $"{ApiData.GetData("weather_summary_value_1d")}\n";

            #endregion

            #endregion

            Console.WriteLine(ApiData.GetData("metar_value_1"));
        }
    }
}
