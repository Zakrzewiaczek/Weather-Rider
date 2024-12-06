namespace Weather_Rider
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            progressLabel = new Label();
            animatedLogo = new PictureBox();
            title = new Label();
            loadingBar = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            ((System.ComponentModel.ISupportInitialize)animatedLogo).BeginInit();
            SuspendLayout();
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            progressLabel.Location = new Point(148, 337);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(61, 41);
            progressLabel.TabIndex = 2;
            progressLabel.Text = "0%";
            progressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // animatedLogo
            // 
            animatedLogo.BackColor = Color.Transparent;
            animatedLogo.Image = Properties.Resources.snowflake_animated;
            animatedLogo.Location = new Point(100, 88);
            animatedLogo.Name = "animatedLogo";
            animatedLogo.Size = new Size(150, 150);
            animatedLogo.TabIndex = 3;
            animatedLogo.TabStop = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            title.Location = new Point(45, 17);
            title.Name = "title";
            title.Size = new Size(262, 50);
            title.TabIndex = 6;
            title.Text = "WeatherRider";
            // 
            // loadingBar
            // 
            loadingBar.BackColor = Color.White;
            loadingBar.InitialRotation = 0D;
            loadingBar.IsClockwise = true;
            loadingBar.Location = new Point(65, 248);
            loadingBar.MaxAngle = 360D;
            loadingBar.MaxValue = null;
            loadingBar.MinValue = 0D;
            loadingBar.Name = "loadingBar";
            loadingBar.Size = new Size(220, 220);
            loadingBar.TabIndex = 8;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.loadingFormBackground;
            ClientSize = new Size(350, 475);
            ControlBox = false;
            Controls.Add(title);
            Controls.Add(animatedLogo);
            Controls.Add(progressLabel);
            Controls.Add(loadingBar);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Loading";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            TopMost = true;
            Load += Loading_Load;
            ((System.ComponentModel.ISupportInitialize)animatedLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label progressLabel;
        private PictureBox animatedLogo;
        private Label title;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart loadingBar;
    }
}