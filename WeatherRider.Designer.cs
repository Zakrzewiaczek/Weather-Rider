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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            header = new Panel();
            controlBoxPanel = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            exit_btn = new PictureBox();
            pictureBox2 = new PictureBox();
            noInternetIcon = new PictureBox();
            station_data_tableLayoutPanel = new TableLayoutPanel();
            station_name_label = new Label();
            left_header_data_panel = new Panel();
            station_feature_code_panel = new Panel();
            station_feature_code_label = new Label();
            station_ICAO_code_panel = new Panel();
            station_ICAO_code_label = new Label();
            right_header_data_panel = new Panel();
            country_code_label = new Label();
            utc_time_label = new Label();
            lat_lon_label = new Label();
            refresh_data_label = new Label();
            change_station_btn = new Button();
            refresh_btn = new Button();
            data_from_label = new Label();
            hr_header = new Panel();
            generalData = new GroupBox();
            general_data = new Label();
            general_description = new Label();
            dailyData = new GroupBox();
            daily_data = new Label();
            daily_description = new Label();
            windData = new GroupBox();
            windDataPictureBox = new PictureBox();
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
            sun_description = new Label();
            airqualityData = new GroupBox();
            beaufort_wind_data_pictures = new PictureBox();
            cloudData = new GroupBox();
            altitudesData = new GroupBox();
            altitudesDataGridView = new DataGridView();
            atlitude = new DataGridViewTextBoxColumn();
            temperature = new DataGridViewTextBoxColumn();
            relative_humidity = new DataGridViewTextBoxColumn();
            wind_speed = new DataGridViewTextBoxColumn();
            wind_direction = new DataGridViewTextBoxColumn();
            beaufort = new DataGridViewTextBoxColumn();
            advancedAtmosphericData = new GroupBox();
            advancedData_data = new Label();
            advancedData_description = new Label();
            station_position_panel = new Panel();
            station_position_label = new Label();
            header.SuspendLayout();
            controlBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noInternetIcon).BeginInit();
            station_data_tableLayoutPanel.SuspendLayout();
            left_header_data_panel.SuspendLayout();
            station_feature_code_panel.SuspendLayout();
            station_ICAO_code_panel.SuspendLayout();
            right_header_data_panel.SuspendLayout();
            generalData.SuspendLayout();
            dailyData.SuspendLayout();
            windData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)windDataPictureBox).BeginInit();
            radiationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uv_index_clear_skyvalue_icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uv_index_value_icon).BeginInit();
            UVPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)beaufort_wind_data_pictures).BeginInit();
            altitudesData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)altitudesDataGridView).BeginInit();
            advancedAtmosphericData.SuspendLayout();
            station_position_panel.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(controlBoxPanel);
            header.Controls.Add(pictureBox2);
            header.Controls.Add(noInternetIcon);
            header.Controls.Add(station_data_tableLayoutPanel);
            header.Controls.Add(lat_lon_label);
            header.Controls.Add(refresh_data_label);
            header.Controls.Add(change_station_btn);
            header.Controls.Add(refresh_btn);
            header.Controls.Add(data_from_label);
            header.Controls.Add(hr_header);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1432, 105);
            header.TabIndex = 0;
            // 
            // controlBoxPanel
            // 
            controlBoxPanel.Controls.Add(pictureBox3);
            controlBoxPanel.Controls.Add(pictureBox1);
            controlBoxPanel.Controls.Add(exit_btn);
            controlBoxPanel.Location = new Point(0, 0);
            controlBoxPanel.Name = "controlBoxPanel";
            controlBoxPanel.Size = new Size(124, 28);
            controlBoxPanel.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(70, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(39, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // exit_btn
            // 
            exit_btn.BackgroundImage = (Image)resources.GetObject("exit_btn.BackgroundImage");
            exit_btn.BackgroundImageLayout = ImageLayout.Zoom;
            exit_btn.Location = new Point(8, 2);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(25, 25);
            exit_btn.TabIndex = 0;
            exit_btn.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.snowflake_animated;
            pictureBox2.Location = new Point(12, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // noInternetIcon
            // 
            noInternetIcon.BackgroundImage = Properties.Resources.noWifiIcon;
            noInternetIcon.BackgroundImageLayout = ImageLayout.Zoom;
            noInternetIcon.Location = new Point(1303, 17);
            noInternetIcon.Name = "noInternetIcon";
            noInternetIcon.Size = new Size(25, 25);
            noInternetIcon.TabIndex = 12;
            noInternetIcon.TabStop = false;
            // 
            // station_data_tableLayoutPanel
            // 
            station_data_tableLayoutPanel.ColumnCount = 3;
            station_data_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            station_data_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            station_data_tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            station_data_tableLayoutPanel.Controls.Add(station_name_label, 1, 0);
            station_data_tableLayoutPanel.Controls.Add(left_header_data_panel, 0, 0);
            station_data_tableLayoutPanel.Controls.Add(right_header_data_panel, 2, 0);
            station_data_tableLayoutPanel.Location = new Point(231, 3);
            station_data_tableLayoutPanel.Name = "station_data_tableLayoutPanel";
            station_data_tableLayoutPanel.RowCount = 1;
            station_data_tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            station_data_tableLayoutPanel.Size = new Size(958, 93);
            station_data_tableLayoutPanel.TabIndex = 11;
            // 
            // station_name_label
            // 
            station_name_label.AutoSize = true;
            station_name_label.Dock = DockStyle.Fill;
            station_name_label.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            station_name_label.Location = new Point(310, 0);
            station_name_label.Name = "station_name_label";
            station_name_label.Size = new Size(337, 93);
            station_name_label.TabIndex = 1;
            station_name_label.Text = "Station Name";
            station_name_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // left_header_data_panel
            // 
            left_header_data_panel.Controls.Add(station_feature_code_panel);
            left_header_data_panel.Controls.Add(station_ICAO_code_panel);
            left_header_data_panel.Dock = DockStyle.Right;
            left_header_data_panel.Location = new Point(156, 3);
            left_header_data_panel.Margin = new Padding(3, 3, 10, 3);
            left_header_data_panel.Name = "left_header_data_panel";
            left_header_data_panel.Size = new Size(141, 87);
            left_header_data_panel.TabIndex = 2;
            // 
            // station_feature_code_panel
            // 
            station_feature_code_panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            station_feature_code_panel.Controls.Add(station_feature_code_label);
            station_feature_code_panel.Location = new Point(19, 44);
            station_feature_code_panel.Margin = new Padding(0);
            station_feature_code_panel.Name = "station_feature_code_panel";
            station_feature_code_panel.Size = new Size(120, 37);
            station_feature_code_panel.TabIndex = 12;
            // 
            // station_feature_code_label
            // 
            station_feature_code_label.AutoSize = true;
            station_feature_code_label.BackColor = Color.White;
            station_feature_code_label.Dock = DockStyle.Right;
            station_feature_code_label.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold);
            station_feature_code_label.Location = new Point(30, 0);
            station_feature_code_label.Name = "station_feature_code_label";
            station_feature_code_label.Size = new Size(90, 35);
            station_feature_code_label.TabIndex = 7;
            station_feature_code_label.Text = "XXXXX";
            station_feature_code_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // station_ICAO_code_panel
            // 
            station_ICAO_code_panel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            station_ICAO_code_panel.Controls.Add(station_ICAO_code_label);
            station_ICAO_code_panel.Location = new Point(19, 7);
            station_ICAO_code_panel.Margin = new Padding(0);
            station_ICAO_code_panel.Name = "station_ICAO_code_panel";
            station_ICAO_code_panel.Size = new Size(120, 37);
            station_ICAO_code_panel.TabIndex = 0;
            // 
            // station_ICAO_code_label
            // 
            station_ICAO_code_label.AutoSize = true;
            station_ICAO_code_label.Dock = DockStyle.Right;
            station_ICAO_code_label.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold);
            station_ICAO_code_label.Location = new Point(45, 0);
            station_ICAO_code_label.Name = "station_ICAO_code_label";
            station_ICAO_code_label.Size = new Size(75, 35);
            station_ICAO_code_label.TabIndex = 10;
            station_ICAO_code_label.Text = "XXXX";
            station_ICAO_code_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // right_header_data_panel
            // 
            right_header_data_panel.Controls.Add(country_code_label);
            right_header_data_panel.Controls.Add(utc_time_label);
            right_header_data_panel.Dock = DockStyle.Left;
            right_header_data_panel.Location = new Point(660, 3);
            right_header_data_panel.Margin = new Padding(10, 3, 3, 3);
            right_header_data_panel.Name = "right_header_data_panel";
            right_header_data_panel.Size = new Size(114, 87);
            right_header_data_panel.TabIndex = 3;
            // 
            // country_code_label
            // 
            country_code_label.AutoSize = true;
            country_code_label.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold);
            country_code_label.Location = new Point(3, 43);
            country_code_label.Name = "country_code_label";
            country_code_label.Size = new Size(60, 35);
            country_code_label.TabIndex = 8;
            country_code_label.Text = "XXX";
            country_code_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // utc_time_label
            // 
            utc_time_label.AutoSize = true;
            utc_time_label.Font = new Font("Segoe UI Semibold", 18.25F, FontStyle.Bold);
            utc_time_label.Location = new Point(3, 9);
            utc_time_label.Name = "utc_time_label";
            utc_time_label.Size = new Size(109, 35);
            utc_time_label.TabIndex = 9;
            utc_time_label.Text = "UTC+XX";
            utc_time_label.TextAlign = ContentAlignment.MiddleLeft;
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
            // refresh_data_label
            // 
            refresh_data_label.AutoSize = true;
            refresh_data_label.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            refresh_data_label.Location = new Point(1320, 57);
            refresh_data_label.Name = "refresh_data_label";
            refresh_data_label.Size = new Size(105, 34);
            refresh_data_label.TabIndex = 5;
            refresh_data_label.Text = "Refresh data:\r\n00.00.0000 00:00";
            refresh_data_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // change_station_btn
            // 
            change_station_btn.Location = new Point(1220, 11);
            change_station_btn.Name = "change_station_btn";
            change_station_btn.Size = new Size(75, 40);
            change_station_btn.TabIndex = 4;
            change_station_btn.Text = "Change\r\nstation";
            change_station_btn.UseVisualStyleBackColor = true;
            // 
            // refresh_btn
            // 
            refresh_btn.Location = new Point(1335, 17);
            refresh_btn.Name = "refresh_btn";
            refresh_btn.Size = new Size(75, 25);
            refresh_btn.TabIndex = 3;
            refresh_btn.Text = "Refresh";
            refresh_btn.UseVisualStyleBackColor = true;
            // 
            // data_from_label
            // 
            data_from_label.AutoSize = true;
            data_from_label.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            data_from_label.Location = new Point(1205, 57);
            data_from_label.Name = "data_from_label";
            data_from_label.Size = new Size(105, 34);
            data_from_label.TabIndex = 2;
            data_from_label.Text = "Data from:\r\n00.00.0000 00:00";
            data_from_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hr_header
            // 
            hr_header.BackColor = Color.FromArgb(5, 42, 117);
            hr_header.Dock = DockStyle.Bottom;
            hr_header.Location = new Point(0, 102);
            hr_header.Name = "hr_header";
            hr_header.Size = new Size(1432, 3);
            hr_header.TabIndex = 0;
            // 
            // generalData
            // 
            generalData.Controls.Add(general_data);
            generalData.Controls.Add(general_description);
            generalData.Location = new Point(12, 111);
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
            dailyData.Location = new Point(317, 111);
            dailyData.Name = "dailyData";
            dailyData.Size = new Size(413, 305);
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
            windData.Controls.Add(windDataPictureBox);
            windData.Controls.Add(wind__data);
            windData.Controls.Add(wind_description);
            windData.Location = new Point(1109, 555);
            windData.Name = "windData";
            windData.Size = new Size(311, 392);
            windData.TabIndex = 3;
            windData.TabStop = false;
            windData.Text = "Wind";
            // 
            // windDataPictureBox
            // 
            windDataPictureBox.BackColor = Color.White;
            windDataPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            windDataPictureBox.Location = new Point(80, 40);
            windDataPictureBox.Name = "windDataPictureBox";
            windDataPictureBox.Size = new Size(155, 155);
            windDataPictureBox.TabIndex = 4;
            windDataPictureBox.TabStop = false;
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
            radiationData.Controls.Add(sun_description);
            radiationData.Location = new Point(736, 111);
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
            uv_index_clear_skyvalue_icon.Location = new Point(244, 132);
            uv_index_clear_skyvalue_icon.Name = "uv_index_clear_skyvalue_icon";
            uv_index_clear_skyvalue_icon.Size = new Size(40, 40);
            uv_index_clear_skyvalue_icon.TabIndex = 13;
            uv_index_clear_skyvalue_icon.TabStop = false;
            // 
            // uv_index_value_icon
            // 
            uv_index_value_icon.BackgroundImage = Properties.Resources.uv_index;
            uv_index_value_icon.BackgroundImageLayout = ImageLayout.Zoom;
            uv_index_value_icon.Location = new Point(86, 132);
            uv_index_value_icon.Name = "uv_index_value_icon";
            uv_index_value_icon.Size = new Size(40, 40);
            uv_index_value_icon.TabIndex = 9;
            uv_index_value_icon.TabStop = false;
            // 
            // uv_index_clear_sky_label1
            // 
            uv_index_clear_sky_label1.AutoSize = true;
            uv_index_clear_sky_label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            uv_index_clear_sky_label1.Location = new Point(217, 257);
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
            uv_index_clear_sky_label2.Location = new Point(231, 277);
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
            uv_index_label.Location = new Point(62, 257);
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
            UVPanel.Location = new Point(35, 167);
            UVPanel.Name = "UVPanel";
            UVPanel.Size = new Size(301, 88);
            UVPanel.TabIndex = 9;
            // 
            // uv_index_clear_sky_gauge
            // 
            uv_index_clear_sky_gauge.InitialRotation = 0D;
            uv_index_clear_sky_gauge.IsClockwise = true;
            uv_index_clear_sky_gauge.Location = new Point(175, 1);
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
            uv_index_gauge.Location = new Point(17, 1);
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
            sun_data.Location = new Point(285, 24);
            sun_data.Name = "sun_data";
            sun_data.Size = new Size(418, 90);
            sun_data.TabIndex = 1;
            sun_data.Text = resources.GetString("sun_data.Text");
            // 
            // sun_description
            // 
            sun_description.AutoSize = true;
            sun_description.Location = new Point(14, 24);
            sun_description.Name = "sun_description";
            sun_description.Size = new Size(217, 90);
            sun_description.TabIndex = 0;
            sun_description.Text = "Shortwave radiation\r\nDirect sky radiation\r\nDiffuse sky radiation\r\nDirect Normal Irradiance (DNI)\r\nGlobal Tilted Irradiation/Irradiance (GTI)\r\nTerrestrial radiation";
            // 
            // airqualityData
            // 
            airqualityData.Location = new Point(1109, 111);
            airqualityData.Name = "airqualityData";
            airqualityData.Size = new Size(311, 438);
            airqualityData.TabIndex = 5;
            airqualityData.TabStop = false;
            airqualityData.Text = "AQI";
            // 
            // beaufort_wind_data_pictures
            // 
            beaufort_wind_data_pictures.BackgroundImage = Properties.Resources.noWifiIcon;
            beaufort_wind_data_pictures.BackgroundImageLayout = ImageLayout.Zoom;
            beaufort_wind_data_pictures.Location = new Point(724, 57);
            beaufort_wind_data_pictures.Name = "beaufort_wind_data_pictures";
            beaufort_wind_data_pictures.Size = new Size(51, 453);
            beaufort_wind_data_pictures.TabIndex = 2;
            beaufort_wind_data_pictures.TabStop = false;
            // 
            // cloudData
            // 
            cloudData.Location = new Point(12, 653);
            cloudData.Name = "cloudData";
            cloudData.Size = new Size(299, 294);
            cloudData.TabIndex = 6;
            cloudData.TabStop = false;
            cloudData.Text = "Clouds";
            // 
            // altitudesData
            // 
            altitudesData.Controls.Add(beaufort_wind_data_pictures);
            altitudesData.Controls.Add(altitudesDataGridView);
            altitudesData.Location = new Point(317, 422);
            altitudesData.Name = "altitudesData";
            altitudesData.Size = new Size(786, 525);
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
            altitudesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            altitudesDataGridView.Columns.AddRange(new DataGridViewColumn[] { atlitude, temperature, relative_humidity, wind_speed, wind_direction, beaufort });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(10, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            altitudesDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            altitudesDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            altitudesDataGridView.Location = new Point(13, 26);
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
            altitudesDataGridView.Size = new Size(767, 493);
            altitudesDataGridView.TabIndex = 0;
            altitudesDataGridView.CellPainting += OnCellPainting;
            // 
            // atlitude
            // 
            dataGridViewCellStyle1.Padding = new Padding(25, 0, 0, 0);
            atlitude.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Padding = new Padding(25, 0, 0, 0);
            temperature.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Padding = new Padding(25, 0, 0, 0);
            relative_humidity.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Padding = new Padding(25, 0, 0, 0);
            wind_speed.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Padding = new Padding(25, 0, 0, 0);
            wind_direction.DefaultCellStyle = dataGridViewCellStyle5;
            wind_direction.Frozen = true;
            wind_direction.HeaderText = "Wind direction";
            wind_direction.Name = "wind_direction";
            wind_direction.ReadOnly = true;
            wind_direction.Resizable = DataGridViewTriState.False;
            wind_direction.SortMode = DataGridViewColumnSortMode.NotSortable;
            wind_direction.Width = 130;
            // 
            // beaufort
            // 
            beaufort.Frozen = true;
            beaufort.HeaderText = "";
            beaufort.Name = "beaufort";
            beaufort.ReadOnly = true;
            beaufort.Width = 50;
            // 
            // advancedAtmosphericData
            // 
            advancedAtmosphericData.Controls.Add(advancedData_data);
            advancedAtmosphericData.Controls.Add(advancedData_description);
            advancedAtmosphericData.Location = new Point(12, 492);
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
            // station_position_panel
            // 
            station_position_panel.Controls.Add(station_position_label);
            station_position_panel.Location = new Point(541, 76);
            station_position_panel.Name = "station_position_panel";
            station_position_panel.Size = new Size(337, 20);
            station_position_panel.TabIndex = 9;
            // 
            // station_position_label
            // 
            station_position_label.Dock = DockStyle.Fill;
            station_position_label.Font = new Font("Segoe UI Semibold", 10.75F, FontStyle.Bold);
            station_position_label.Location = new Point(0, 0);
            station_position_label.Name = "station_position_label";
            station_position_label.Size = new Size(337, 20);
            station_position_label.TabIndex = 0;
            station_position_label.Text = "Lat: 52.16575°          Lon: 20.96712°";
            station_position_label.TextAlign = ContentAlignment.BottomCenter;
            // 
            // WeatherRider
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1432, 959);
            Controls.Add(station_position_panel);
            Controls.Add(cloudData);
            Controls.Add(advancedAtmosphericData);
            Controls.Add(altitudesData);
            Controls.Add(airqualityData);
            Controls.Add(radiationData);
            Controls.Add(windData);
            Controls.Add(dailyData);
            Controls.Add(generalData);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "WeatherRider";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather Rider";
            TransparencyKey = Color.FromArgb(240, 224, 224);
            WindowState = FormWindowState.Minimized;
            FormClosing += ClosingApplication;
            header.ResumeLayout(false);
            header.PerformLayout();
            controlBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit_btn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)noInternetIcon).EndInit();
            station_data_tableLayoutPanel.ResumeLayout(false);
            station_data_tableLayoutPanel.PerformLayout();
            left_header_data_panel.ResumeLayout(false);
            station_feature_code_panel.ResumeLayout(false);
            station_feature_code_panel.PerformLayout();
            station_ICAO_code_panel.ResumeLayout(false);
            station_ICAO_code_panel.PerformLayout();
            right_header_data_panel.ResumeLayout(false);
            right_header_data_panel.PerformLayout();
            generalData.ResumeLayout(false);
            generalData.PerformLayout();
            dailyData.ResumeLayout(false);
            dailyData.PerformLayout();
            windData.ResumeLayout(false);
            windData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)windDataPictureBox).EndInit();
            radiationData.ResumeLayout(false);
            radiationData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uv_index_clear_skyvalue_icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)uv_index_value_icon).EndInit();
            UVPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)beaufort_wind_data_pictures).EndInit();
            altitudesData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)altitudesDataGridView).EndInit();
            advancedAtmosphericData.ResumeLayout(false);
            advancedAtmosphericData.PerformLayout();
            station_position_panel.ResumeLayout(false);
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
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart uv_index_gauge;
        private Panel UVPanel;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart uv_index_clear_sky_gauge;
        private Label uv_index_label;
        private Label uv_index_clear_sky_label1;
        private Label uv_index_clear_sky_label2;
        private PictureBox uv_index_value_icon;
        private PictureBox uv_index_clear_skyvalue_icon;
        private Label station_name_label;
        private Label data_from_label;
        private Button change_station_btn;
        private Button refresh_btn;
        private Label refresh_data_label;
        private Label lat_lon_label;
        private Label station_feature_code_label;
        private Label country_code_label;
        private Label utc_time_label;
        private Label station_ICAO_code_label;
        private TableLayoutPanel station_data_tableLayoutPanel;
        private Panel left_header_data_panel;
        private Panel right_header_data_panel;
        private Panel station_position_panel;
        private Label station_position_label;
        private Panel station_feature_code_panel;
        private Panel station_ICAO_code_panel;
        private PictureBox noInternetIcon;
        private PictureBox beaufort_wind_data_pictures;
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn atlitude;
        private DataGridViewTextBoxColumn temperature;
        private DataGridViewTextBoxColumn relative_humidity;
        private DataGridViewTextBoxColumn wind_speed;
        private DataGridViewTextBoxColumn wind_direction;
        private DataGridViewTextBoxColumn beaufort;
        private PictureBox windDataPictureBox;
        private Panel controlBoxPanel;
        private PictureBox exit_btn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}
