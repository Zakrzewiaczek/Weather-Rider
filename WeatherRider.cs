

using System.Diagnostics;

using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System.DirectoryServices.ActiveDirectory;
using System.Text.RegularExpressions;

namespace Weather_Rider
{
    public partial class WeatherRider : Form
    {
        private readonly Loading loadingForm = new();


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

                WeatherAPI weatherAPI = new(new(52.5889, 20.8055));
                loadingForm.Progress = 8;

                Thread.Sleep(800);

                bool isException = false;
                try
                {
                    weatherAPI.Update();
                    loadingForm.Progress = 30;
                }
                catch (HttpSenderErrorException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isException = true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show($"There is most likely a time mismatch issue.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isException = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Application error, try again later\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isException = true;
                }

                if (isException)
                {
                    loadingForm.Exit();
                    return;
                }

                // Displaying all data
                Debug.WriteLine("Displaying all data");
                foreach (var (key, value) in weatherAPI.AllData)
                {
                    Debug.WriteLine($"{key}: {value}");
                }

                loadingForm.Progress = 60;
                SettingUpLabels(weatherAPI);

                // Wait for the progress bar to finish
                await Task.Delay(200);
                loadingForm.Progress = 100;
                await Task.Delay(100);

                // Show the WeatherRider form
                Invoke(Show);
                await Task.Delay(300);
                Invoke(() => WindowState = FormWindowState.Normal);
                loadingForm.Exit();
            });
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

                    if (weatherAPI.AllData.TryGetValue(key, out (object data, string unit) value))
                    {
                        (object? data, string unit) = value;
                        string toReplace = isUnit ? unit : CustomFormatter(key, data?.ToString() ?? string.Empty);

                        // If there is no data, set it to "N/A" (data only)
                        if (toReplace == string.Empty && !isUnit)
                            toReplace = "N/A";
                        // If the date is "N/A" then we do not display the unit (set it to string.Empty)
                        if (CustomFormatter(key, data?.ToString() ?? string.Empty) == string.Empty && isUnit)
                            toReplace = string.Empty;

                        Debug.WriteLine($"Replacing {match} with {toReplace}");
                        label.Invoke(() => label.Text = label.Text.Replace(match.ToString(), toReplace));
                    }
                }
                new Task(async () => 
                {
                    await Task.Delay(10);
                    loadingForm.Progress += 2;
                }).Start();
            }
        }

        public static string CustomFormatter(string key, string value)
        {
            string output = value;

            switch (key)
            {
                case "sunrise":
                case "sunset":
                    if (DateTime.TryParse(value, null, System.Globalization.DateTimeStyles.RoundtripKind, out DateTime dateTime))
                    {
                        output = dateTime.ToString("HH:mm");
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

                        output = $"{hours}h {minutes}m {remainigSeconds + ulamekSekund}s";
                    }
                    break;
            };

            return output;
        }



        [GeneratedRegex(@"\{[A-Za-z0-9_]+(\.(data|unit))\}")]
        private static partial Regex ToSubstituteValues();
    }
}
