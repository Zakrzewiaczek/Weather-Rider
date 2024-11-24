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
            loadingBar = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            progressLabel = new Label();
            SuspendLayout();
            // 
            // loadingBar
            // 
            loadingBar.InitialRotation = 0D;
            loadingBar.IsClockwise = true;
            loadingBar.Location = new Point(65, 180);
            loadingBar.MaxAngle = 360D;
            loadingBar.MaxValue = null;
            loadingBar.MinValue = 0D;
            loadingBar.Name = "loadingBar";
            loadingBar.Size = new Size(220, 220);
            loadingBar.TabIndex = 0;
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            progressLabel.Location = new Point(148, 269);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(61, 41);
            progressLabel.TabIndex = 2;
            progressLabel.Text = "0%";
            progressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 400);
            ControlBox = false;
            Controls.Add(progressLabel);
            Controls.Add(loadingBar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += Loading_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LiveChartsCore.SkiaSharpView.WinForms.PieChart loadingBar;
        private Label progressLabel;
    }
}