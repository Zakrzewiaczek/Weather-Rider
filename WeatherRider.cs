using System.Diagnostics;

using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Extensions;
using SkiaSharp;
using System.Text.RegularExpressions;
using LiveChartsCore.Measure;
using LiveChartsCore.Defaults;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;

namespace Weather_Rider
{
    public partial class WeatherRider : Form
    {
        private readonly Loading loadingForm = Program.loadingForm;
        private InternetConnectionManagment? internetManager = null;

        public WeatherRider()
        {
            Debug.WriteLine("WeatherRider constructor called");
            InitializeComponent();
            Debug.WriteLine("Components initialized");

            Shown += (s, e) => Hide(); // Hide the form until the data is loaded
            LoadApp(); // Load the app (in background)
        }

        private async void LoadApp()
        {
            Debug.WriteLine("Loading app");
            loadingForm.Show();

            await Task.Delay(820);

            await Task.Run(async () =>
            {
                loadingForm.Progress = 5;
                //Debug.WriteLine(WeatherAPI.GetPlaceByName("EPWA").Lat);
                Thread.Sleep(300);

                WeatherAPI weatherAPI = new(new(52.5889, 20.8055), CustomFormatter);
                loadingForm.Progress = 8;
                Thread.Sleep(800);

                try
                {
                    weatherAPI.Update();
                    loadingForm.Progress = 30;
                }
                catch (HttpSenderErrorException ex)
                {
                    ThrowException(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    ThrowException($"There is most likely a time mismatch issue.\n{ex.Message}");
                }
                catch (Exception ex)
                {
                    ThrowException("Application error, try again later\n" + ex.Message);
                }

                loadingForm.Progress = 40;

                await SettingUpHeaderLabels();
                SettingUpLabels(weatherAPI);
                SettingUpaltitudesDataGridView(weatherAPI);
                SettingUpUVGauges(weatherAPI);

                // Wait for the progress bar to finish
                await Task.Delay(200);
                loadingForm.Progress = 100;
                await Task.Delay(100);

                // Show the WeatherRider form
                await Invoke(async () =>
                {
                    Show();
                    await Task.Delay(300);
                    WindowState = FormWindowState.Normal;
                });
                loadingForm.Exit();

                new Thread(() =>
                {
                    internetManager = new(noInternetIcon);
                    internetManager.CheckConnection();
                }).Start();
            });
        }


        private void ThrowException(string? description)
        {
            loadingForm.Invoke(() => loadingForm.TopMost = false);
            MessageBox.Show(description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            loadingForm.Invoke(loadingForm.Exit);
            Application.Exit();
        }



        private static List<Label> GetAllLabels(Control control)
        {
            var labels = new List<Label>();

            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Label label)
                {
                    labels.Add(label);
                }

                if (ctrl.HasChildren)
                {
                    labels.AddRange(GetAllLabels(ctrl));
                }
            }

            return labels;
        }

        private void SettingUpLabels(WeatherAPI weatherAPI)
        {
            // Set the labels
            Debug.WriteLine("____________\n\nSetting up labels");

            var labels = GetAllLabels(this);
            foreach (var label in labels)
            {
                Debug.WriteLine($"\nSetting up label {label.Name}");

                string labelText = label.Text;
                var matches = ToSubstituteValues().Matches(labelText);
                Debug.WriteLine($"Matches: {matches.Count}");

                foreach (Match match in matches)
                {
                    string key = match.ToString()[1..^1];
                    bool isUnit = key.EndsWith(".unit");
                    key = key.Replace(".unit", "").Replace(".data", "");

                    if (weatherAPI.TryGetData(key, out var value))
                    {
                        (string data, string unit) = value;
                        string toReplace = isUnit ? unit : data;

                        Invoke(() => label.Text = label.Text.Replace(match.ToString(), toReplace));
                    }
                }
                new Task(async () =>
                {
                    await Task.Delay(10);
                    loadingForm.Progress += 2;
                }).Start();
            }
        }
        private void SettingUpUVGauges(WeatherAPI weatherAPI)
        {
            /*string numberString = number.ToString("G17", System.Globalization.CultureInfo.InvariantCulture);

            // Znalezienie pozycji przecinka
            int decimalPointIndex = numberString.IndexOf('.');

            // Jeœli nie ma przecinka, liczba nie ma cyfr po przecinku
            if (decimalPointIndex == -1)
            {
                return 0;
            }

            // Zwrócenie liczby cyfr po przecinku
            return numberString.Length - decimalPointIndex - 1;*/


            #region UV Index

            double UVIndex = -1;
            if (weatherAPI.TryGetData("uv_index", out var uvIndexData))
            {
                if (double.TryParse(uvIndexData.data, out double value))
                    UVIndex = value;
            }

            SKColor UVIndexColor = UVIndex switch
            {
                < 3 => SKColors.Green,
                < 6 => SKColors.Yellow,
                < 8 => SKColors.Orange,
                < 11 => SKColors.Red,
                _ => SKColors.Purple
            };
            SKColor UVIndexLabelColor = UVIndex switch
            {
                < 6 => SKColors.Black,
                < 8 => SKColors.Orange,
                < 11 => SKColors.Red,
                _ => SKColors.Purple
            };


            IEnumerable<ISeries> UVIndexSeries = GaugeGenerator.BuildSolidGauge(
                new GaugeItem(UVIndex == -1 ? 11 : (UVIndex > 11 ? UVIndex = 11 : UVIndex), series =>
                {
                    series.Fill = new SolidColorPaint(UVIndex != -1 ? UVIndexColor : new SKColor(245, 245, 245));
                    series.DataLabelsSize = 23;
                    series.DataLabelsPaint = new SolidColorPaint(UVIndex != -1 ? UVIndexLabelColor : SKColors.White);
                    series.DataLabelsPosition = PolarLabelsPosition.ChartCenter;
                    series.InnerRadius = 23;
                }),
                new GaugeItem(GaugeItem.Background, series =>
                {
                    series.InnerRadius = 23;
                    series.Fill = new SolidColorPaint(new SKColor(235, 235, 235));
                })
            );


            uv_index_gauge.Tooltip = null;
            uv_index_gauge.Series = UVIndexSeries;
            uv_index_gauge.InitialRotation = -225;
            uv_index_gauge.MaxAngle = 270;
            uv_index_gauge.MinValue = 0;
            uv_index_gauge.MaxValue = 11;

            #endregion
            #region UV Index Clear Sky

            double UVIndexClearSky = -1;
            if (weatherAPI.TryGetData("uv_index_clear_sky", out var uvIndexClearSkyData))
            {
                if (double.TryParse(uvIndexClearSkyData.data, out double value))
                    UVIndexClearSky = value;
            }

            SKColor UVIndexClearSkyColor = UVIndexClearSky switch
            {
                < 3 => SKColors.Green,
                < 6 => SKColors.Yellow,
                < 8 => SKColors.Orange,
                < 11 => SKColors.Red,
                _ => SKColors.Purple
            };
            SKColor UVIndexClearSkyLabelColor = UVIndexClearSky switch
            {
                < 6 => SKColors.Black,
                < 8 => SKColors.Orange,
                < 11 => SKColors.Red,
                _ => SKColors.Purple
            };


            IEnumerable<ISeries> UVIndexClearSkySeries = GaugeGenerator.BuildSolidGauge(
                new GaugeItem(UVIndexClearSky == -1 ? 11 : (UVIndexClearSky > 11 ? UVIndexClearSky = 11 : UVIndexClearSky), series =>
                {
                    series.Fill = new SolidColorPaint(UVIndexClearSky != -1 ? UVIndexClearSkyColor : new SKColor(245, 245, 245));
                    series.DataLabelsSize = 23;
                    series.DataLabelsPaint = new SolidColorPaint(UVIndexClearSky != -1 ? UVIndexClearSkyLabelColor : SKColors.White);
                    series.DataLabelsPosition = PolarLabelsPosition.ChartCenter;
                    series.InnerRadius = 23;
                }),
                new GaugeItem(GaugeItem.Background, series =>
                {
                    series.InnerRadius = 23;
                    series.Fill = new SolidColorPaint(new SKColor(235, 235, 235));
                })
            );


            uv_index_clear_sky_gauge.Tooltip = null;
            uv_index_clear_sky_gauge.Series = UVIndexClearSkySeries;
            uv_index_clear_sky_gauge.InitialRotation = -225;
            uv_index_clear_sky_gauge.MaxAngle = 270;
            uv_index_clear_sky_gauge.MinValue = 0;
            uv_index_clear_sky_gauge.MaxValue = 11;

            #endregion
        }

        private void SettingUpaltitudesDataGridView(WeatherAPI weatherAPI)
        {
            string[] suffixes = ["1000hPa", "975hPa", "950hPa", "925hPa", "900hPa", "850hPa", "800hPa", "700hPa", "600hPa", "500hPa", "400hPa", "300hPa", "250hPa", "200hPa", "150hPa", "100hPa", "70hPa", "50hPa", "30hPa"];
            string[] altitudes = ["110 m", "320 m", "500 m", "800 m", "1000 m", "1500 m", "1900 m", "3 km", "4.2 km", "5.6 km", "7.2 km", "9.2 km", "10.4 km", "11.8 km", "13.5 km", "15.8 km", "17.7 km", "19.3 km", "22 km"];

            Debug.WriteLine(suffixes.Length);

            altitudesDataGridView.AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            altitudesDataGridView.AdvancedColumnHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            altitudesDataGridView.AdvancedRowHeadersBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
            altitudesDataGridView.BorderStyle = BorderStyle.None;
            altitudesDataGridView.RowTemplate.Height = altitudesDataGridView.Size.Height / (suffixes.Length + 1);

            for (int index = 0; index < suffixes.Length; index++)
            {
                string altitude = $"{suffixes[index]} ({altitudes[index]})";
                string temperature = weatherAPI.TryGetData($"temperature_{suffixes[index]}", out var tempData) ? $"{tempData.data} {tempData.unit}" : string.Empty;
                string humidity = weatherAPI.TryGetData($"relative_humidity_{suffixes[index]}", out var humData) ? $"{humData.data} {humData.unit}" : string.Empty;
                string windSpeed = weatherAPI.TryGetData($"wind_speed_{suffixes[index]}", out var windSpeedData) ? $"{windSpeedData.data} {windSpeedData.unit}" : string.Empty;
                string windDirection = weatherAPI.TryGetData($"wind_direction_{suffixes[index]}", out var windDirectionData) ? windDirectionData.data : string.Empty;

                Invoke(() => altitudesDataGridView.Rows.Add(altitude, temperature, humidity, windSpeed, windDirection));
                Debug.WriteLine(altitude);
            }

            new Task(async () =>
            {
                await Task.Delay(10);
                loadingForm.Progress += 2;
            }).Start();
        }
        private async Task SettingUpHeaderLabels()
        {
            Place? station = null;
            await Task.Run(async () =>
            {
                var places = await WeatherAPI.GetPlaceByNameAsync(GlobalSettings.Default.WeatherStationICAO);
                station = places.FirstOrDefault();
            });

            if (!station.HasValue)
                throw new InvalidOperationException("Station not found.");

            Invoke(() =>
            {
                utc_time_label.Text = Date.GetUTCFromTimezone(Date.GetTimezoneByName(GlobalSettings.Default.Timezone));
                station_feature_code_label.Text = station.Value.FeatureCode?.Trim();
                station_ICAO_code_label.Text = GlobalSettings.Default.WeatherStationICAO;
                country_code_label.Text = station.Value.CountryCode;
                station_name_label.Text = station.Value.Name;

                string lat = station.Value.Lat.ToString(CultureInfo.InvariantCulture);
                string lon = station.Value.Lon.ToString(CultureInfo.InvariantCulture);
                station_position_label.Text = $"Latitude: {lat}°          Longitude: {lon}°";
            });
        }


        private void OnCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(altitudesDataGridView.ColumnHeadersDefaultCellStyle.BackColor))
                {
                    e?.Graphics?.FillRectangle(b, e.CellBounds);
                }
                e?.PaintContent(e.ClipBounds);
            }
            /*else if (e.RowIndex == 0 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                e.PaintBackground(e.ClipBounds, true);
                e.PaintContent(e.ClipBounds);
                using (Pen p = new Pen(altitudesDataGridView.GridColor))
                {
                    e?.Graphics?.DrawLine(p, e.CellBounds.Left, e.CellBounds.Top + 5, e.CellBounds.Right, e.CellBounds.Top + 5);
                }
            }*/
        }

        public static (string data, string unit) CustomFormatter(string key, string? value, string? unit)
        {
            string? dataOut = value, unitOut = unit;
            if (value == null || value == string.Empty)
                return ("N/A", "");

            switch (key)
            {
                case "sunrise":
                case "sunset":
                    if (DateTime.TryParse(value, null, System.Globalization.DateTimeStyles.RoundtripKind, out DateTime dateTime))
                    {
                        dataOut = dateTime.ToString("HH:mm");
                    }
                    break;

                case "daylight_duration":
                case "sunshine_duration":
                    if (float.TryParse(value, out float daylightDuration))
                    {
                        int intSeconds = (int)daylightDuration;
                        int hours = intSeconds / 3600;
                        int minutes = (intSeconds % 3600) / 60;
                        int remainigSeconds = intSeconds % 60;
                        float ulamekSekund = daylightDuration - intSeconds;

                        dataOut = $"{hours}h {minutes}m {remainigSeconds + ulamekSekund}s";
                    }
                    break;

                default:
                    if (key.StartsWith("wind_direction_"))
                    {
                        if (double.TryParse(value, out double windDirection))
                        {
                            string windDirectionSide = windDirection switch
                            {
                                >= 348.75 or < 11.25 => "N",
                                >= 11.25 and < 33.75 => "NNE",
                                >= 33.75 and < 56.25 => "NE",
                                >= 56.25 and < 78.75 => "ENE",
                                >= 78.75 and < 101.25 => "E",
                                >= 101.25 and < 123.75 => "ESE",
                                >= 123.75 and < 146.25 => "SE",
                                >= 146.25 and < 168.75 => "SSE",
                                >= 168.75 and < 191.25 => "S",
                                >= 191.25 and < 213.75 => "SSW",
                                >= 213.75 and < 236.25 => "SW",
                                >= 236.25 and < 258.75 => "WSW",
                                >= 258.75 and < 281.25 => "W",
                                >= 281.25 and < 303.75 => "WNW",
                                >= 303.75 and < 326.25 => "NW",
                                >= 326.25 and < 348.75 => "NNW",
                                _ => "N/A"
                            };

                            dataOut = $"{windDirection}{unit} ({windDirectionSide})";
                            unitOut = string.Empty;
                        }
                    }
                    break;
            };

            if (dataOut == null || dataOut == string.Empty)
                return ("N/A", "");

            return (dataOut, unitOut ?? string.Empty);
        }

        private void ClosingApplication(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("Closing application...");
            new Thread(() => internetManager!.Close());
        }



        [GeneratedRegex(@"\{[A-Za-z0-9_]+(\.(data|unit))\}")]
        private static partial Regex ToSubstituteValues();
    }
}
