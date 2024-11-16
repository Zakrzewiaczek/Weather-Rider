

using System.Diagnostics;

using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using System.DirectoryServices.ActiveDirectory;

namespace Weather_Rider
{
    public partial class WeatherRider : Form
    {
        public WeatherRider()
        {
            Debug.WriteLine("WeatherRider constructor called");
            InitializeComponent();
            Debug.WriteLine("Components initialized");
        }

        private void LoadApp(object sender, EventArgs e)
        {
            Debug.WriteLine("Loading app");
            WeatherAPI weatherAPI = new(new(52.5889, 20.8055));

            weatherAPI.Update();

            Debug.WriteLine("Data\n\n\n\n");

            Thread.Sleep(5000);

            foreach (var item in weatherAPI.AllData)
                Debug.WriteLine($"{item.Key} => {item.Value.data} [{item.Value.unit}]");
        }
    }
}
