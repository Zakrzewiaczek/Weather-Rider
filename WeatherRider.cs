

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
            //Debug.WriteLine(WeatherAPI.GetPlaceByName("EPWA").Lat);
            WeatherAPI weatherAPI = new(new(52.5889, 20.8055));

            try
            {
                weatherAPI.Update();
            }
            catch (HttpSenderErrorException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0x00000001);
            }

            Debug.WriteLine("Data\n\n\n\n");

            foreach (var item in weatherAPI.AllData)
                Debug.WriteLine($"{item.Key} => {item.Value.data} [{item.Value.unit}]");
        }

        public static Image RotateImage(Image image, float angle)
        {
            Bitmap rotatedBmp = new(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedBmp))
            {
                g.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);
                g.DrawImage(image, new Point(0, 0));
            }

            return rotatedBmp;
        }
    }
}
