using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.Measure;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace Weather_Rider
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        public uint Progress
        {
            get => progress;
            set
            {
                progress = value;
                SetProgress();
            }
        }
        private uint progress;

        private void Loading_Load(object sender, EventArgs e)
        {
            IEnumerable<ISeries> series =
            [
                new PieSeries<int>
                {
                    Values = [1],
                    InnerRadius = 63, // Wcięcie od środka
                    //Fill = new SolidColorPaint(new SKColor(0x00, 0xBF, 0xFF)) // Kolor wykresu na niebieski (RGB)
                    Fill = new SolidColorPaint(SKColor.Parse("#052A75")) // Kolor wykresu na niebieski (HEX)
                }
            ];

            // Zrobić ładowanie się aplikacji jak gauge

            loadingBar.Tooltip = null; // Usunięcie tooltipa
            loadingBar.MaxAngle = 0; // Początkowy kąt
            loadingBar.Series = series;
            loadingBar.InitialRotation = -90; // Początkowy obrót
        }

        private void SetProgress()
        {
            loadingBar.MaxAngle = (double)progress / 100 * 360;
            progressLabel.Invoke(new Action(() =>
            {
                progressLabel.Text = $"{progress}%";

                if (progress == 100)
                    progressLabel.Location = new Point(132, progressLabel.Location.Y);
                else if (progress >= 0 && progress < 10)
                    progressLabel.Location = new Point(148, progressLabel.Location.Y);
                else
                    progressLabel.Location = new Point(142, progressLabel.Location.Y);
            }));
        }

        public void Exit()
        {
            Invoke(Close);
        }
    }
}
