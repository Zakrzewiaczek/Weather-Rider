namespace Weather_Data
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.generalData = new System.Windows.Forms.Panel();
            this.generalData_data_out = new System.Windows.Forms.Label();
            this.generalDataLabel = new System.Windows.Forms.Label();
            this.detailedData = new System.Windows.Forms.Panel();
            this.windData = new System.Windows.Forms.Panel();
            this.windDataLabel2 = new System.Windows.Forms.Label();
            this.windData_data_out = new System.Windows.Forms.Label();
            this.windDataLabel = new System.Windows.Forms.Label();
            this.windDataPictureBox = new System.Windows.Forms.PictureBox();
            this.cloudData = new System.Windows.Forms.Panel();
            this.headerLabel = new System.Windows.Forms.Label();
            this.cloudData_data_out = new System.Windows.Forms.Label();
            this.cloudDataLabel = new System.Windows.Forms.Label();
            this.airData = new System.Windows.Forms.Panel();
            this.generalData.SuspendLayout();
            this.windData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windDataPictureBox)).BeginInit();
            this.cloudData.SuspendLayout();
            this.SuspendLayout();
            // 
            // generalData
            // 
            this.generalData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.generalData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generalData.Controls.Add(this.generalData_data_out);
            this.generalData.Controls.Add(this.generalDataLabel);
            this.generalData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generalData.Location = new System.Drawing.Point(23, 82);
            this.generalData.Margin = new System.Windows.Forms.Padding(4);
            this.generalData.Name = "generalData";
            this.generalData.Size = new System.Drawing.Size(394, 240);
            this.generalData.TabIndex = 0;
            // 
            // generalData_data_out
            // 
            this.generalData_data_out.AutoSize = true;
            this.generalData_data_out.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generalData_data_out.Location = new System.Drawing.Point(257, 24);
            this.generalData_data_out.Name = "generalData_data_out";
            this.generalData_data_out.Size = new System.Drawing.Size(57, 190);
            this.generalData_data_out.TabIndex = 7;
            this.generalData_data_out.Text = "XXXXXX\r\nXXXXXX\r\nXXXXXX\r\n\r\nXXXXXX\r\n\r\nXXXXXX\r\nXXXXXX\r\n\r\nXXXXXX";
            this.generalData_data_out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generalDataLabel
            // 
            this.generalDataLabel.AutoSize = true;
            this.generalDataLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generalDataLabel.Location = new System.Drawing.Point(28, 23);
            this.generalDataLabel.Name = "generalDataLabel";
            this.generalDataLabel.Size = new System.Drawing.Size(169, 190);
            this.generalDataLabel.TabIndex = 0;
            this.generalDataLabel.Text = "Air temerature\r\nSoil temperature\r\nWater temperature\r\n\r\nRelative humidity\r\n\r\nPress" +
    "ure\r\nPressure (sea level)\r\n\r\nPrecipitation accumulated";
            this.generalDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // detailedData
            // 
            this.detailedData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.detailedData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailedData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.detailedData.Location = new System.Drawing.Point(430, 82);
            this.detailedData.Margin = new System.Windows.Forms.Padding(4);
            this.detailedData.Name = "detailedData";
            this.detailedData.Size = new System.Drawing.Size(433, 240);
            this.detailedData.TabIndex = 1;
            // 
            // windData
            // 
            this.windData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.windData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.windData.Controls.Add(this.windDataLabel2);
            this.windData.Controls.Add(this.windData_data_out);
            this.windData.Controls.Add(this.windDataLabel);
            this.windData.Controls.Add(this.windDataPictureBox);
            this.windData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.windData.Location = new System.Drawing.Point(476, 336);
            this.windData.Margin = new System.Windows.Forms.Padding(4);
            this.windData.Name = "windData";
            this.windData.Size = new System.Drawing.Size(604, 287);
            this.windData.TabIndex = 2;
            // 
            // windDataLabel2
            // 
            this.windDataLabel2.AutoSize = true;
            this.windDataLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.windDataLabel2.Location = new System.Drawing.Point(436, 46);
            this.windDataLabel2.Name = "windDataLabel2";
            this.windDataLabel2.Size = new System.Drawing.Size(103, 21);
            this.windDataLabel2.TabIndex = 10;
            this.windDataLabel2.Text = "Wind gauge";
            // 
            // windData_data_out
            // 
            this.windData_data_out.AutoSize = true;
            this.windData_data_out.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.windData_data_out.Location = new System.Drawing.Point(214, 31);
            this.windData_data_out.Name = "windData_data_out";
            this.windData_data_out.Size = new System.Drawing.Size(57, 228);
            this.windData_data_out.TabIndex = 9;
            this.windData_data_out.Text = "XXXXXX\r\nXXXXXX\r\nXXXXXX\r\nXXXXXX\r\n\r\nXXXXXX\r\n\r\nXXXXXX\r\nXXXXXX\r\nXXXXXX\r\n\r\nXXXXXX";
            this.windData_data_out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windDataLabel
            // 
            this.windDataLabel.AutoSize = true;
            this.windDataLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.windDataLabel.Location = new System.Drawing.Point(51, 30);
            this.windDataLabel.Name = "windDataLabel";
            this.windDataLabel.Size = new System.Drawing.Size(123, 228);
            this.windDataLabel.TabIndex = 8;
            this.windDataLabel.Text = "Wind Speed\r\n\r\n\r\n\r\n\r\nWind direction\r\n\r\nWind Gust\r\nPeak_Wind Speed\r\nSonic_Wind Spee" +
    "d\r\n\r\nAltimeter";
            this.windDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windDataPictureBox
            // 
            this.windDataPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("windDataPictureBox.BackgroundImage")));
            this.windDataPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.windDataPictureBox.Location = new System.Drawing.Point(412, 77);
            this.windDataPictureBox.Name = "windDataPictureBox";
            this.windDataPictureBox.Size = new System.Drawing.Size(150, 150);
            this.windDataPictureBox.TabIndex = 0;
            this.windDataPictureBox.TabStop = false;
            // 
            // cloudData
            // 
            this.cloudData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cloudData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cloudData.Controls.Add(this.cloudData_data_out);
            this.cloudData.Controls.Add(this.cloudDataLabel);
            this.cloudData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cloudData.Location = new System.Drawing.Point(23, 336);
            this.cloudData.Margin = new System.Windows.Forms.Padding(4);
            this.cloudData.Name = "cloudData";
            this.cloudData.Size = new System.Drawing.Size(445, 287);
            this.cloudData.TabIndex = 3;
            // 
            // headerLabel
            // 
            this.headerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.Location = new System.Drawing.Point(326, 19);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(459, 38);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "WEATHER STATION: XXXXX, XX";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cloudData_data_out
            // 
            this.cloudData_data_out.AutoSize = true;
            this.cloudData_data_out.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cloudData_data_out.Location = new System.Drawing.Point(272, 29);
            this.cloudData_data_out.Name = "cloudData_data_out";
            this.cloudData_data_out.Size = new System.Drawing.Size(57, 152);
            this.cloudData_data_out.TabIndex = 12;
            this.cloudData_data_out.Text = "XXXXXX\r\nXXXXXX\r\nXXXXXX\r\n\r\nXXXXXX\r\n\r\nXXXXXX\r\nXXXXXX";
            this.cloudData_data_out.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cloudDataLabel
            // 
            this.cloudDataLabel.AutoSize = true;
            this.cloudDataLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cloudDataLabel.Location = new System.Drawing.Point(47, 29);
            this.cloudDataLabel.Name = "cloudDataLabel";
            this.cloudDataLabel.Size = new System.Drawing.Size(123, 152);
            this.cloudDataLabel.TabIndex = 11;
            this.cloudDataLabel.Text = "Cloud layer 1\r\nCloud layer 2\r\nCloud layer 3\r\n\r\nCeiling\r\n\r\nWeather condition\r\nWeat" +
    "her summary";
            this.cloudDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // airData
            // 
            this.airData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.airData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.airData.Location = new System.Drawing.Point(874, 82);
            this.airData.Margin = new System.Windows.Forms.Padding(4);
            this.airData.Name = "airData";
            this.airData.Size = new System.Drawing.Size(206, 240);
            this.airData.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1093, 636);
            this.Controls.Add(this.airData);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cloudData);
            this.Controls.Add(this.windData);
            this.Controls.Add(this.detailedData);
            this.Controls.Add(this.generalData);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Weather Rider";
            this.generalData.ResumeLayout(false);
            this.generalData.PerformLayout();
            this.windData.ResumeLayout(false);
            this.windData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windDataPictureBox)).EndInit();
            this.cloudData.ResumeLayout(false);
            this.cloudData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel generalData;
        private System.Windows.Forms.Panel detailedData;
        private System.Windows.Forms.Panel windData;
        private System.Windows.Forms.Panel cloudData;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label generalDataLabel;
        public System.Windows.Forms.Label generalData_data_out;
        public System.Windows.Forms.PictureBox windDataPictureBox;
        public System.Windows.Forms.Label windData_data_out;
        private System.Windows.Forms.Label windDataLabel2;
        public System.Windows.Forms.Label windDataLabel;
        public System.Windows.Forms.Label cloudData_data_out;
        public System.Windows.Forms.Label cloudDataLabel;
        private System.Windows.Forms.Panel airData;
    }
}

