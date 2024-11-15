

using System.Diagnostics;

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
            WeatherAPI weatherAPI = new()
            {
                Place = new(52.1658, 20.9671)
            };
            weatherAPI.HttpRequest();

            Debug.WriteLine("Done.");
        }
    }
}
