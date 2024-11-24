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
            progressLabel = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            title = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            progressLabel.Location = new Point(148, 318);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(61, 41);
            progressLabel.TabIndex = 2;
            progressLabel.Text = "0%";
            progressLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.snowflake_animated1;
            pictureBox1.Location = new Point(98, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(274, 111);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pieChart1
            // 
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(65, 229);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = null;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(220, 220);
            pieChart1.TabIndex = 5;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            title.Location = new Point(45, 18);
            title.Name = "title";
            title.Size = new Size(262, 50);
            title.TabIndex = 6;
            title.Text = "WeatherRider";
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(350, 450);
            ControlBox = false;
            Controls.Add(title);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(progressLabel);
            Controls.Add(pieChart1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label progressLabel;
        private PictureBox pictureBox1;
        private Button button1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private Label title;
    }
}