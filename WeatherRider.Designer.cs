namespace Weather_Rider
{
    partial class WeatherRider
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherRider));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            header = new Panel();
            hr_header = new Panel();
            generalData = new GroupBox();
            general_data = new Label();
            general_description = new Label();
            dailyData = new GroupBox();
            daily_data = new Label();
            daily_description = new Label();
            windData = new GroupBox();
            wind__data = new Label();
            wind_description = new Label();
            radiationData = new GroupBox();
            sun_data = new Label();
            sun_description = new Label();
            airqualityData = new GroupBox();
            cloudData = new GroupBox();
            altitudesData = new GroupBox();
            altitudesDataGridView = new DataGridView();
            atlitude = new DataGridViewTextBoxColumn();
            temperature = new DataGridViewTextBoxColumn();
            relative_humidity = new DataGridViewTextBoxColumn();
            wind_speed = new DataGridViewTextBoxColumn();
            wind_direction = new DataGridViewTextBoxColumn();
            advancedAtmosphericData = new GroupBox();
            advancedData_data = new Label();
            advancedData_description = new Label();
            header.SuspendLayout();
            generalData.SuspendLayout();
            dailyData.SuspendLayout();
            windData.SuspendLayout();
            radiationData.SuspendLayout();
            altitudesData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)altitudesDataGridView).BeginInit();
            advancedAtmosphericData.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(hr_header);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1432, 86);
            header.TabIndex = 0;
            // 
            // hr_header
            // 
            hr_header.BackColor = Color.FromArgb(5, 42, 117);
            hr_header.Dock = DockStyle.Bottom;
            hr_header.Location = new Point(0, 83);
            hr_header.Name = "hr_header";
            hr_header.Size = new Size(1432, 3);
            hr_header.TabIndex = 0;
            // 
            // generalData
            // 
            generalData.Controls.Add(general_data);
            generalData.Controls.Add(general_description);
            generalData.Location = new Point(12, 92);
            generalData.Name = "generalData";
            generalData.Size = new Size(299, 278);
            generalData.TabIndex = 1;
            generalData.TabStop = false;
            generalData.Text = "General";
            // 
            // general_data
            // 
            general_data.AutoSize = true;
            general_data.Location = new Point(180, 33);
            general_data.Name = "general_data";
            general_data.Size = new Size(356, 225);
            general_data.TabIndex = 10;
            general_data.Text = resources.GetString("general_data.Text");
            // 
            // general_description
            // 
            general_description.AutoSize = true;
            general_description.Location = new Point(14, 33);
            general_description.Name = "general_description";
            general_description.Size = new Size(131, 225);
            general_description.TabIndex = 9;
            general_description.Text = resources.GetString("general_description.Text");
            // 
            // dailyData
            // 
            dailyData.Controls.Add(daily_data);
            dailyData.Controls.Add(daily_description);
            dailyData.Location = new Point(317, 92);
            dailyData.Name = "dailyData";
            dailyData.Size = new Size(413, 278);
            dailyData.TabIndex = 2;
            dailyData.TabStop = false;
            dailyData.Text = "Daily";
            // 
            // daily_data
            // 
            daily_data.AutoSize = true;
            daily_data.Location = new Point(280, 32);
            daily_data.Name = "daily_data";
            daily_data.Size = new Size(402, 225);
            daily_data.TabIndex = 10;
            daily_data.Text = resources.GetString("daily_data.Text");
            // 
            // daily_description
            // 
            daily_description.AutoSize = true;
            daily_description.Location = new Point(16, 32);
            daily_description.Name = "daily_description";
            daily_description.Size = new Size(178, 225);
            daily_description.TabIndex = 9;
            daily_description.Text = resources.GetString("daily_description.Text");
            // 
            // windData
            // 
            windData.Controls.Add(wind__data);
            windData.Controls.Add(wind_description);
            windData.Location = new Point(1109, 439);
            windData.Name = "windData";
            windData.Size = new Size(311, 392);
            windData.TabIndex = 3;
            windData.TabStop = false;
            windData.Text = "Wind";
            // 
            // wind__data
            // 
            wind__data.AutoSize = true;
            wind__data.Location = new Point(199, 313);
            wind__data.Name = "wind__data";
            wind__data.Size = new Size(147, 45);
            wind__data.TabIndex = 1;
            wind__data.Text = "{wind_speed_10m.data}\r\n{wind_direction_10m.data}\r\n{wind_gusts_10m.data}";
            // 
            // wind_description
            // 
            wind_description.AutoSize = true;
            wind_description.Location = new Point(19, 313);
            wind_description.Name = "wind_description";
            wind_description.Size = new Size(268, 45);
            wind_description.TabIndex = 0;
            wind_description.Text = "Wind speed (10m) [{wind_speed_10m.unit}]\r\nWind direction (10m) [{wind_direction_10m.unit}]\r\nWind gust (10m) [{wind_gusts_10m.unit}]\r\n";
            // 
            // radiationData
            // 
            radiationData.Controls.Add(sun_data);
            radiationData.Controls.Add(sun_description);
            radiationData.Location = new Point(736, 92);
            radiationData.Name = "radiationData";
            radiationData.Size = new Size(367, 278);
            radiationData.TabIndex = 4;
            radiationData.TabStop = false;
            radiationData.Text = "Sun radiation";
            // 
            // sun_data
            // 
            sun_data.AutoSize = true;
            sun_data.Location = new Point(260, 36);
            sun_data.Name = "sun_data";
            sun_data.Size = new Size(418, 225);
            sun_data.TabIndex = 1;
            sun_data.Text = resources.GetString("sun_data.Text");
            // 
            // sun_description
            // 
            sun_description.AutoSize = true;
            sun_description.Location = new Point(10, 36);
            sun_description.Name = "sun_description";
            sun_description.Size = new Size(217, 225);
            sun_description.TabIndex = 0;
            sun_description.Text = resources.GetString("sun_description.Text");
            // 
            // airqualityData
            // 
            airqualityData.Location = new Point(1109, 92);
            airqualityData.Name = "airqualityData";
            airqualityData.Size = new Size(311, 341);
            airqualityData.TabIndex = 5;
            airqualityData.TabStop = false;
            airqualityData.Text = "AQI";
            // 
            // cloudData
            // 
            cloudData.Location = new Point(12, 537);
            cloudData.Name = "cloudData";
            cloudData.Size = new Size(299, 294);
            cloudData.TabIndex = 6;
            cloudData.TabStop = false;
            cloudData.Text = "Clouds";
            // 
            // altitudesData
            // 
            altitudesData.Controls.Add(altitudesDataGridView);
            altitudesData.Location = new Point(317, 376);
            altitudesData.Name = "altitudesData";
            altitudesData.Size = new Size(786, 455);
            altitudesData.TabIndex = 7;
            altitudesData.TabStop = false;
            altitudesData.Text = "Data at different heights";
            // 
            // altitudesDataGridView
            // 
            altitudesDataGridView.AllowUserToAddRows = false;
            altitudesDataGridView.AllowUserToDeleteRows = false;
            altitudesDataGridView.AllowUserToResizeColumns = false;
            altitudesDataGridView.AllowUserToResizeRows = false;
            altitudesDataGridView.BackgroundColor = Color.White;
            altitudesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            altitudesDataGridView.Columns.AddRange(new DataGridViewColumn[] { atlitude, temperature, relative_humidity, wind_speed, wind_direction });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            altitudesDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            altitudesDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            altitudesDataGridView.Location = new Point(19, 29);
            altitudesDataGridView.MultiSelect = false;
            altitudesDataGridView.Name = "altitudesDataGridView";
            altitudesDataGridView.ReadOnly = true;
            altitudesDataGridView.RowHeadersVisible = false;
            altitudesDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            altitudesDataGridView.ScrollBars = ScrollBars.Vertical;
            altitudesDataGridView.ShowCellErrors = false;
            altitudesDataGridView.ShowCellToolTips = false;
            altitudesDataGridView.ShowEditingIcon = false;
            altitudesDataGridView.ShowRowErrors = false;
            altitudesDataGridView.Size = new Size(750, 408);
            altitudesDataGridView.TabIndex = 0;
            // 
            // atlitude
            // 
            atlitude.Frozen = true;
            atlitude.HeaderText = "Atlitude";
            atlitude.Name = "atlitude";
            atlitude.ReadOnly = true;
            atlitude.Resizable = DataGridViewTriState.False;
            atlitude.SortMode = DataGridViewColumnSortMode.NotSortable;
            atlitude.Width = 230;
            // 
            // temperature
            // 
            temperature.Frozen = true;
            temperature.HeaderText = "Temperature";
            temperature.Name = "temperature";
            temperature.ReadOnly = true;
            temperature.Resizable = DataGridViewTriState.False;
            temperature.SortMode = DataGridViewColumnSortMode.NotSortable;
            temperature.Width = 130;
            // 
            // relative_humidity
            // 
            relative_humidity.Frozen = true;
            relative_humidity.HeaderText = "Relative Humidity";
            relative_humidity.Name = "relative_humidity";
            relative_humidity.ReadOnly = true;
            relative_humidity.Resizable = DataGridViewTriState.False;
            relative_humidity.SortMode = DataGridViewColumnSortMode.NotSortable;
            relative_humidity.Width = 130;
            // 
            // wind_speed
            // 
            wind_speed.Frozen = true;
            wind_speed.HeaderText = "Wind speed";
            wind_speed.Name = "wind_speed";
            wind_speed.ReadOnly = true;
            wind_speed.Resizable = DataGridViewTriState.False;
            wind_speed.SortMode = DataGridViewColumnSortMode.NotSortable;
            wind_speed.Width = 130;
            // 
            // wind_direction
            // 
            wind_direction.Frozen = true;
            wind_direction.HeaderText = "Wind direction";
            wind_direction.Name = "wind_direction";
            wind_direction.ReadOnly = true;
            wind_direction.Resizable = DataGridViewTriState.False;
            wind_direction.SortMode = DataGridViewColumnSortMode.NotSortable;
            wind_direction.Width = 130;
            // 
            // advancedAtmosphericData
            // 
            advancedAtmosphericData.Controls.Add(advancedData_data);
            advancedAtmosphericData.Controls.Add(advancedData_description);
            advancedAtmosphericData.Location = new Point(12, 376);
            advancedAtmosphericData.Name = "advancedAtmosphericData";
            advancedAtmosphericData.Size = new Size(299, 155);
            advancedAtmosphericData.TabIndex = 8;
            advancedAtmosphericData.TabStop = false;
            advancedAtmosphericData.Text = "Advanced atmospheric data";
            // 
            // advancedData_data
            // 
            advancedData_data.AutoSize = true;
            advancedData_data.Location = new Point(219, 29);
            advancedData_data.Name = "advancedData_data";
            advancedData_data.Size = new Size(486, 105);
            advancedData_data.TabIndex = 0;
            advancedData_data.Text = resources.GetString("advancedData_data.Text");
            // 
            // advancedData_description
            // 
            advancedData_description.AutoSize = true;
            advancedData_description.Location = new Point(11, 29);
            advancedData_description.Name = "advancedData_description";
            advancedData_description.Size = new Size(191, 105);
            advancedData_description.TabIndex = 0;
            advancedData_description.Text = "CAPE\r\nEvapotranspiration\r\nReference evapotranspiration (ETo)\r\nVapour pressure deficyt (VPD)\r\nIntegrated Water Vapour (IWV)\r\nBoundary layer height\r\nConvective inhibition";
            // 
            // WeatherRider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1432, 843);
            Controls.Add(cloudData);
            Controls.Add(advancedAtmosphericData);
            Controls.Add(altitudesData);
            Controls.Add(airqualityData);
            Controls.Add(radiationData);
            Controls.Add(windData);
            Controls.Add(dailyData);
            Controls.Add(generalData);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "WeatherRider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather Rider";
            WindowState = FormWindowState.Minimized;
            header.ResumeLayout(false);
            generalData.ResumeLayout(false);
            generalData.PerformLayout();
            dailyData.ResumeLayout(false);
            dailyData.PerformLayout();
            windData.ResumeLayout(false);
            windData.PerformLayout();
            radiationData.ResumeLayout(false);
            radiationData.PerformLayout();
            altitudesData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)altitudesDataGridView).EndInit();
            advancedAtmosphericData.ResumeLayout(false);
            advancedAtmosphericData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private GroupBox generalData;
        private GroupBox dailyData;
        private GroupBox windData;
        private GroupBox radiationData;
        private GroupBox airqualityData;
        private GroupBox cloudData;
        private GroupBox altitudesData;
        private GroupBox advancedAtmosphericData;
        private Label general_data;
        private Label general_description;
        private Label daily_description;
        private Label daily_data;
        private Label advancedData_description;
        private Label advancedData_data;
        private Label wind__data;
        private Label wind_description;
        private Label sun_data;
        private Label sun_description;
        private Panel hr_header;
        private DataGridView altitudesDataGridView;
        private DataGridViewTextBoxColumn atlitude;
        private DataGridViewTextBoxColumn temperature;
        private DataGridViewTextBoxColumn relative_humidity;
        private DataGridViewTextBoxColumn wind_speed;
        private DataGridViewTextBoxColumn wind_direction;
    }
}
