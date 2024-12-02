﻿namespace Weather_Rider
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
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
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
            uv_index_clear_skyvalue_icon = new PictureBox();
            uv_index_value_icon = new PictureBox();
            uv_index_clear_sky_label1 = new Label();
            uv_index_clear_sky_label2 = new Label();
            uv_index_label = new Label();
            UVPanel = new Panel();
            uv_index_clear_sky_gauge = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            uv_index_gauge = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            sun_data = new Label();
            uv_index_icon = new PictureBox();
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
            label1 = new Label();
            data_from_label = new Label();
            refresh_btn = new Button();
            change_station_btn = new Button();
            refresh_data_label = new Label();
            lat_lon_label = new Label();
            station_feature_code_label = new Label();
            country_code_label = new Label();
            label2 = new Label();
            header.SuspendLayout();
            generalData.SuspendLayout();
            dailyData.SuspendLayout();
            windData.SuspendLayout();
            radiationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uv_index_clear_skyvalue_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uv_index_value_icon).BeginInit();
            UVPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uv_index_icon).BeginInit();
            altitudesData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)altitudesDataGridView).BeginInit();
            advancedAtmosphericData.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(label2);
            header.Controls.Add(country_code_label);
            header.Controls.Add(station_feature_code_label);
            header.Controls.Add(label1);
            header.Controls.Add(lat_lon_label);
            header.Controls.Add(refresh_data_label);
            header.Controls.Add(change_station_btn);
            header.Controls.Add(refresh_btn);
            header.Controls.Add(data_from_label);
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
            generalData.Size = new Size(299, 375);
            generalData.TabIndex = 1;
            generalData.TabStop = false;
            generalData.Text = "General";
            // 
            // general_data
            // 
            general_data.AutoSize = true;
            general_data.Location = new Point(180, 140);
            general_data.Name = "general_data";
            general_data.Size = new Size(356, 225);
            general_data.TabIndex = 10;
            general_data.Text = resources.GetString("general_data.Text");
            // 
            // general_description
            // 
            general_description.AutoSize = true;
            general_description.Location = new Point(14, 140);
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
            dailyData.Size = new Size(413, 344);
            dailyData.TabIndex = 2;
            dailyData.TabStop = false;
            dailyData.Text = "Daily";
            // 
            // daily_data
            // 
            daily_data.AutoSize = true;
            daily_data.Location = new Point(280, 28);
            daily_data.Name = "daily_data";
            daily_data.Size = new Size(402, 225);
            daily_data.TabIndex = 10;
            daily_data.Text = resources.GetString("daily_data.Text");
            // 
            // daily_description
            // 
            daily_description.AutoSize = true;
            daily_description.Location = new Point(16, 28);
            daily_description.Name = "daily_description";
            daily_description.Size = new Size(178, 225);
            daily_description.TabIndex = 9;
            daily_description.Text = resources.GetString("daily_description.Text");
            // 
            // windData
            // 
            windData.Controls.Add(wind__data);
            windData.Controls.Add(wind_description);
            windData.Location = new Point(1109, 536);
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
            radiationData.Controls.Add(uv_index_clear_skyvalue_icon);
            radiationData.Controls.Add(uv_index_value_icon);
            radiationData.Controls.Add(uv_index_clear_sky_label1);
            radiationData.Controls.Add(uv_index_clear_sky_label2);
            radiationData.Controls.Add(uv_index_label);
            radiationData.Controls.Add(UVPanel);
            radiationData.Controls.Add(sun_data);
            radiationData.Controls.Add(uv_index_icon);
            radiationData.Controls.Add(sun_description);
            radiationData.Location = new Point(736, 92);
            radiationData.Name = "radiationData";
            radiationData.Size = new Size(367, 305);
            radiationData.TabIndex = 4;
            radiationData.TabStop = false;
            radiationData.Text = "Sun radiation";
            // 
            // uv_index_clear_skyvalue_icon
            // 
            uv_index_clear_skyvalue_icon.BackgroundImage = Properties.Resources.uv_index_clear_sky;
            uv_index_clear_skyvalue_icon.BackgroundImageLayout = ImageLayout.Zoom;
            uv_index_clear_skyvalue_icon.Location = new Point(283, 132);
            uv_index_clear_skyvalue_icon.Name = "uv_index_clear_skyvalue_icon";
            uv_index_clear_skyvalue_icon.Size = new Size(40, 40);
            uv_index_clear_skyvalue_icon.TabIndex = 13;
            uv_index_clear_skyvalue_icon.TabStop = false;
            // 
            // uv_index_value_icon
            // 
            uv_index_value_icon.BackgroundImage = Properties.Resources.uv_index;
            uv_index_value_icon.BackgroundImageLayout = ImageLayout.Zoom;
            uv_index_value_icon.Location = new Point(165, 132);
            uv_index_value_icon.Name = "uv_index_value_icon";
            uv_index_value_icon.Size = new Size(40, 40);
            uv_index_value_icon.TabIndex = 9;
            uv_index_value_icon.TabStop = false;
            // 
            // uv_index_clear_sky_label1
            // 
            uv_index_clear_sky_label1.AutoSize = true;
            uv_index_clear_sky_label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            uv_index_clear_sky_label1.Location = new Point(256, 257);
            uv_index_clear_sky_label1.Name = "uv_index_clear_sky_label1";
            uv_index_clear_sky_label1.Size = new Size(90, 25);
            uv_index_clear_sky_label1.TabIndex = 11;
            uv_index_clear_sky_label1.Text = "UV Index";
            uv_index_clear_sky_label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uv_index_clear_sky_label2
            // 
            uv_index_clear_sky_label2.AutoSize = true;
            uv_index_clear_sky_label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            uv_index_clear_sky_label2.Location = new Point(270, 277);
            uv_index_clear_sky_label2.Name = "uv_index_clear_sky_label2";
            uv_index_clear_sky_label2.Size = new Size(63, 19);
            uv_index_clear_sky_label2.TabIndex = 12;
            uv_index_clear_sky_label2.Text = "clear sky";
            uv_index_clear_sky_label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uv_index_label
            // 
            uv_index_label.AutoSize = true;
            uv_index_label.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            uv_index_label.Location = new Point(141, 257);
            uv_index_label.Name = "uv_index_label";
            uv_index_label.Size = new Size(90, 25);
            uv_index_label.TabIndex = 10;
            uv_index_label.Text = "UV Index";
            uv_index_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UVPanel
            // 
            UVPanel.Controls.Add(uv_index_clear_sky_gauge);
            UVPanel.Controls.Add(uv_index_gauge);
            UVPanel.Location = new Point(133, 167);
            UVPanel.Name = "UVPanel";
            UVPanel.Size = new Size(221, 88);
            UVPanel.TabIndex = 9;
            // 
            // uv_index_clear_sky_gauge
            // 
            uv_index_clear_sky_gauge.InitialRotation = 0D;
            uv_index_clear_sky_gauge.IsClockwise = true;
            uv_index_clear_sky_gauge.Location = new Point(115, 0);
            uv_index_clear_sky_gauge.MaxAngle = 360D;
            uv_index_clear_sky_gauge.MaxValue = null;
            uv_index_clear_sky_gauge.MinValue = 0D;
            uv_index_clear_sky_gauge.Name = "uv_index_clear_sky_gauge";
            uv_index_clear_sky_gauge.Size = new Size(106, 106);
            uv_index_clear_sky_gauge.TabIndex = 11;
            // 
            // uv_index_gauge
            // 
            uv_index_gauge.InitialRotation = 0D;
            uv_index_gauge.IsClockwise = true;
            uv_index_gauge.Location = new Point(0, 0);
            uv_index_gauge.MaxAngle = 360D;
            uv_index_gauge.MaxValue = null;
            uv_index_gauge.MinValue = 0D;
            uv_index_gauge.Name = "uv_index_gauge";
            uv_index_gauge.Size = new Size(106, 106);
            uv_index_gauge.TabIndex = 10;
            // 
            // sun_data
            // 
            sun_data.AutoSize = true;
            sun_data.Location = new Point(260, 24);
            sun_data.Name = "sun_data";
            sun_data.Size = new Size(418, 90);
            sun_data.TabIndex = 1;
            sun_data.Text = resources.GetString("sun_data.Text");
            // 
            // uv_index_icon
            // 
            uv_index_icon.BackgroundImage = Properties.Resources.uv_index_icon;
            uv_index_icon.BackgroundImageLayout = ImageLayout.Zoom;
            uv_index_icon.Location = new Point(19, 164);
            uv_index_icon.Name = "uv_index_icon";
            uv_index_icon.Size = new Size(95, 95);
            uv_index_icon.TabIndex = 9;
            uv_index_icon.TabStop = false;
            // 
            // sun_description
            // 
            sun_description.AutoSize = true;
            sun_description.Location = new Point(10, 24);
            sun_description.Name = "sun_description";
            sun_description.Size = new Size(217, 90);
            sun_description.TabIndex = 0;
            sun_description.Text = "Shortwave radiation\r\nDirect sky radiation\r\nDiffuse sky radiation\r\nDirect Normal Irradiance (DNI)\r\nGlobal Tilted Irradiation/Irradiance (GTI)\r\nTerrestrial radiation";
            // 
            // airqualityData
            // 
            airqualityData.Location = new Point(1109, 92);
            airqualityData.Name = "airqualityData";
            airqualityData.Size = new Size(311, 438);
            airqualityData.TabIndex = 5;
            airqualityData.TabStop = false;
            airqualityData.Text = "AQI";
            // 
            // cloudData
            // 
            cloudData.Location = new Point(12, 634);
            cloudData.Name = "cloudData";
            cloudData.Size = new Size(299, 294);
            cloudData.TabIndex = 6;
            cloudData.TabStop = false;
            cloudData.Text = "Clouds";
            // 
            // altitudesData
            // 
            altitudesData.Controls.Add(altitudesDataGridView);
            altitudesData.Location = new Point(317, 442);
            altitudesData.Name = "altitudesData";
            altitudesData.Size = new Size(786, 486);
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
            altitudesDataGridView.ColumnHeadersHeight = 27;
            altitudesDataGridView.Columns.AddRange(new DataGridViewColumn[] { atlitude, temperature, relative_humidity, wind_speed, wind_direction });
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle18.SelectionBackColor = Color.White;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            altitudesDataGridView.DefaultCellStyle = dataGridViewCellStyle18;
            altitudesDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            altitudesDataGridView.Location = new Point(16, 29);
            altitudesDataGridView.Margin = new Padding(0);
            altitudesDataGridView.MultiSelect = false;
            altitudesDataGridView.Name = "altitudesDataGridView";
            altitudesDataGridView.ReadOnly = true;
            altitudesDataGridView.RowHeadersVisible = false;
            altitudesDataGridView.RowHeadersWidth = 40;
            altitudesDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            altitudesDataGridView.ScrollBars = ScrollBars.None;
            altitudesDataGridView.ShowCellErrors = false;
            altitudesDataGridView.ShowCellToolTips = false;
            altitudesDataGridView.ShowEditingIcon = false;
            altitudesDataGridView.ShowRowErrors = false;
            altitudesDataGridView.Size = new Size(713, 455);
            altitudesDataGridView.TabIndex = 0;
            altitudesDataGridView.CellPainting += OnCellPainting;
            // 
            // atlitude
            // 
            dataGridViewCellStyle13.Padding = new Padding(25, 0, 0, 0);
            atlitude.DefaultCellStyle = dataGridViewCellStyle13;
            atlitude.Frozen = true;
            atlitude.HeaderText = "Atlitude";
            atlitude.Name = "atlitude";
            atlitude.ReadOnly = true;
            atlitude.Resizable = DataGridViewTriState.False;
            atlitude.SortMode = DataGridViewColumnSortMode.NotSortable;
            atlitude.Width = 190;
            // 
            // temperature
            // 
            dataGridViewCellStyle14.Padding = new Padding(25, 0, 0, 0);
            temperature.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Padding = new Padding(25, 0, 0, 0);
            relative_humidity.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Padding = new Padding(25, 0, 0, 0);
            wind_speed.DefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Padding = new Padding(25, 0, 0, 0);
            wind_direction.DefaultCellStyle = dataGridViewCellStyle17;
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
            advancedAtmosphericData.Location = new Point(12, 473);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(538, -1);
            label1.Name = "label1";
            label1.Size = new Size(337, 65);
            label1.TabIndex = 1;
            label1.Text = "Station Name";
            // 
            // data_from_label
            // 
            data_from_label.AutoSize = true;
            data_from_label.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            data_from_label.Location = new Point(1211, 46);
            data_from_label.Name = "data_from_label";
            data_from_label.Size = new Size(105, 34);
            data_from_label.TabIndex = 2;
            data_from_label.Text = "Data from:\r\n00.00.0000 00:00";
            data_from_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // refresh_btn
            // 
            refresh_btn.Location = new Point(1341, 14);
            refresh_btn.Name = "refresh_btn";
            refresh_btn.Size = new Size(75, 23);
            refresh_btn.TabIndex = 3;
            refresh_btn.Text = "Refresh";
            refresh_btn.UseVisualStyleBackColor = true;
            // 
            // change_station_btn
            // 
            change_station_btn.Location = new Point(12, 12);
            change_station_btn.Name = "change_station_btn";
            change_station_btn.Size = new Size(75, 40);
            change_station_btn.TabIndex = 4;
            change_station_btn.Text = "Change\r\nstation";
            change_station_btn.UseVisualStyleBackColor = true;
            // 
            // refresh_data_label
            // 
            refresh_data_label.AutoSize = true;
            refresh_data_label.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            refresh_data_label.Location = new Point(1322, 46);
            refresh_data_label.Name = "refresh_data_label";
            refresh_data_label.Size = new Size(105, 34);
            refresh_data_label.TabIndex = 5;
            refresh_data_label.Text = "Refresh data:\r\n00.00.0000 00:00";
            refresh_data_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lat_lon_label
            // 
            lat_lon_label.AutoSize = true;
            lat_lon_label.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lat_lon_label.Location = new Point(587, 60);
            lat_lon_label.Name = "lat_lon_label";
            lat_lon_label.Size = new Size(259, 20);
            lat_lon_label.TabIndex = 6;
            lat_lon_label.Text = "Lat: 52.585354°          Lon: 20.791443°";
            // 
            // station_feature_code_label
            // 
            station_feature_code_label.AutoSize = true;
            station_feature_code_label.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold);
            station_feature_code_label.Location = new Point(430, 6);
            station_feature_code_label.Name = "station_feature_code_label";
            station_feature_code_label.Size = new Size(90, 35);
            station_feature_code_label.TabIndex = 7;
            station_feature_code_label.Text = "XXXXX";
            // 
            // country_code_label
            // 
            country_code_label.AutoSize = true;
            country_code_label.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold);
            country_code_label.Location = new Point(430, 43);
            country_code_label.Name = "country_code_label";
            country_code_label.Size = new Size(60, 35);
            country_code_label.TabIndex = 8;
            country_code_label.Text = "XXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold);
            label2.Location = new Point(901, 4);
            label2.Name = "label2";
            label2.Size = new Size(109, 35);
            label2.TabIndex = 9;
            label2.Text = "UTC+XX";
            // 
            // WeatherRider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1432, 939);
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
            header.PerformLayout();
            generalData.ResumeLayout(false);
            generalData.PerformLayout();
            dailyData.ResumeLayout(false);
            dailyData.PerformLayout();
            windData.ResumeLayout(false);
            windData.PerformLayout();
            radiationData.ResumeLayout(false);
            radiationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uv_index_clear_skyvalue_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)uv_index_value_icon).EndInit();
            UVPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uv_index_icon).EndInit();
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
        private PictureBox uv_index_icon;
        private DataGridViewTextBoxColumn atlitude;
        private DataGridViewTextBoxColumn temperature;
        private DataGridViewTextBoxColumn relative_humidity;
        private DataGridViewTextBoxColumn wind_speed;
        private DataGridViewTextBoxColumn wind_direction;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart uv_index_gauge;
        private Panel UVPanel;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart uv_index_clear_sky_gauge;
        private Label uv_index_label;
        private Label uv_index_clear_sky_label1;
        private Label uv_index_clear_sky_label2;
        private PictureBox uv_index_value_icon;
        private PictureBox uv_index_clear_skyvalue_icon;
        private Label label1;
        private Label data_from_label;
        private Button change_station_btn;
        private Button refresh_btn;
        private Label refresh_data_label;
        private Label lat_lon_label;
        private Label station_feature_code_label;
        private Label country_code_label;
        private Label label2;
    }
}
