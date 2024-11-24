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
            IEnumerable<ISeries> series = new List<ISeries>
            {
                new PieSeries<int>
                {
                    Values = new List<int> { 1 },
                    InnerRadius = 60, // Wcięcie od środka
                    Fill = new SolidColorPaint(SKColors.DeepSkyBlue), // Kolor wykresu na niebieski
                }
            };

            loadingBar.Tooltip = null; // Usunięcie tooltipa
            loadingBar.Series = series;
            loadingBar.MaxAngle = 0; // Początkowy kąt
            loadingBar.InitialRotation = -90; // Początkowy obrót
        }

        private void SetProgress()
        {
            loadingBar.MaxAngle = (double)progress / 100 * 360;
            progressLabel.Text = $"{progress}%";

            if (progress == 100)
                progressLabel.Location = new Point(132, 269);
            else if (progress >= 0 && progress < 10)
                progressLabel.Location = new Point(148, 269);
            else
                progressLabel.Location = new Point(142, 269);
        }

        public void Exit()
        {
            Application.Exit();
        }
    }
}
