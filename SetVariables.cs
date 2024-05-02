using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private int ConvertKmHToBeaufort(float windSpeedKmH)
        {
            if (windSpeedKmH < 1) return 0;
            if (windSpeedKmH < 6) return 1;
            if (windSpeedKmH < 12) return 2;
            if (windSpeedKmH < 20) return 3;
            if (windSpeedKmH < 29) return 4;
            if (windSpeedKmH < 39) return 5;
            if (windSpeedKmH < 50) return 6;
            if (windSpeedKmH < 62) return 7;
            if (windSpeedKmH < 75) return 8;
            if (windSpeedKmH < 89) return 9;
            if (windSpeedKmH < 103) return 10;
            if (windSpeedKmH < 118) return 11;

            return 12; // Dla prędkości wiatru 118 km/h i więcej
        }


        public void SetData()
        {
            #region generalData Panel

            form.generalData_data_out.Text =
                $"{ApiData.GetData("air_temp_value_1")} °C\n" +
                $"{ApiData.GetData("soil_temp_1")} °C\n" +
                $"{ApiData.GetData("water_temp_1")} °C\n\n" +
                $"{ApiData.GetData("relative_humidity_value_1")} %\n\n" +
                $"{float.Parse(ApiData.GetData("pressure_value_1d")) / 100} hPa\n" +
                $"{float.Parse(ApiData.GetData("sea_level_pressure_value_1d")) / 100} hPa\n\n" +
                $"{ApiData.GetData("precip_accum_1")} mm\n";

            #endregion
            #region windData Panel

            int beaufort = ConvertKmHToBeaufort(float.Parse(ApiData.GetData("wind_speed_value_1")));

            Bitmap icon = (Bitmap)Resources.ResourceManager.GetObject($"scale{beaufort}");
            icon = Image.Rotate(icon, new PointF(icon.Width / 2, icon.Height / 2), Int32.Parse(ApiData.GetData("wind_direction_value_1")) - 55);

            form.windDataPictureBox.BackgroundImage = icon;

            string peak_wind_str = ApiData.GetData("peak_wind_speed_1");
            string sonic_wind_str = ApiData.GetData("sonic_wind_speed_1");

            if (peak_wind_str != "--")
                peak_wind_str = (float.Parse(peak_wind_str) / 3.6).ToString();
            if (sonic_wind_str != "--")
                sonic_wind_str = (float.Parse(sonic_wind_str) / 3.6).ToString();
            
            #region Label

            form.windData_data_out.Text =
                $"{ApiData.GetData("wind_speed_value_1")} km/h\n" +
                $"{float.Parse(ApiData.GetData("wind_speed_value_1")) / 3.6} m/s\n" +
                $"{float.Parse(ApiData.GetData("wind_speed_value_1")) * 0.621371} mph\n" +
                $"{beaufort} beaufort\n\n" +
                $"{ApiData.GetData("wind_direction_value_1")}° ({ApiData.GetData("wind_cardinal_direction_value_1d")})\n\n" +
                $"{ApiData.GetData("wind_gust_value_1")} km/h\n" +
                $"{peak_wind_str} m/s\n" +
                $"{sonic_wind_str} m/s\n\n" +
                $"{float.Parse(ApiData.GetData("altimeter_value_1")) / 100} hPa";

            #endregion
            #endregion
            #region cloudData Panel

            form.cloudData_data_out.Text =
                $"" +
                $"" +
                $"";

            #endregion
        }
    }
}
