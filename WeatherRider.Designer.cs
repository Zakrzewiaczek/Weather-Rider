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
            header = new Panel();
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
            altitudesDataTable = new TableLayoutPanel();
            windDirection_1000hPa = new Label();
            windSpeed_1000hPa = new Label();
            humidity_1000hPa = new Label();
            temperature_1000hPa = new Label();
            tableAtlitudeTitle = new Label();
            tableDirectionTitle = new Label();
            tableSpeedTitle = new Label();
            tableHumidityTitle = new Label();
            tableTempTitle = new Label();
            atlitude_1000hPa = new Label();
            advancedAtmosphericData = new GroupBox();
            advancedData_data = new Label();
            advancedData_description = new Label();
            generalData.SuspendLayout();
            dailyData.SuspendLayout();
            windData.SuspendLayout();
            radiationData.SuspendLayout();
            altitudesData.SuspendLayout();
            altitudesDataTable.SuspendLayout();
            advancedAtmosphericData.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1432, 86);
            header.TabIndex = 0;
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
            altitudesData.Controls.Add(altitudesDataTable);
            altitudesData.Location = new Point(317, 376);
            altitudesData.Name = "altitudesData";
            altitudesData.Size = new Size(786, 455);
            altitudesData.TabIndex = 7;
            altitudesData.TabStop = false;
            altitudesData.Text = "Data at different heights";
            // 
            // altitudesDataTable
            // 
            altitudesDataTable.ColumnCount = 5;
            altitudesDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            altitudesDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            altitudesDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            altitudesDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            altitudesDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            altitudesDataTable.Controls.Add(windDirection_1000hPa, 4, 1);
            altitudesDataTable.Controls.Add(windSpeed_1000hPa, 3, 1);
            altitudesDataTable.Controls.Add(humidity_1000hPa, 2, 1);
            altitudesDataTable.Controls.Add(temperature_1000hPa, 1, 1);
            altitudesDataTable.Controls.Add(tableAtlitudeTitle, 0, 0);
            altitudesDataTable.Controls.Add(tableDirectionTitle, 4, 0);
            altitudesDataTable.Controls.Add(tableSpeedTitle, 3, 0);
            altitudesDataTable.Controls.Add(tableHumidityTitle, 2, 0);
            altitudesDataTable.Controls.Add(tableTempTitle, 1, 0);
            altitudesDataTable.Controls.Add(atlitude_1000hPa, 0, 1);
            altitudesDataTable.Location = new Point(19, 30);
            altitudesDataTable.Name = "altitudesDataTable";
            altitudesDataTable.RowCount = 2;
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            altitudesDataTable.RowStyles.Add(new RowStyle());
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            altitudesDataTable.Size = new Size(750, 419);
            altitudesDataTable.TabIndex = 0;
            // 
            // windDirection_1000hPa
            // 
            windDirection_1000hPa.AutoSize = true;
            windDirection_1000hPa.Dock = DockStyle.Fill;
            windDirection_1000hPa.Location = new Point(614, 48);
            windDirection_1000hPa.Margin = new Padding(3, 10, 3, 0);
            windDirection_1000hPa.Name = "windDirection_1000hPa";
            windDirection_1000hPa.Size = new Size(133, 371);
            windDirection_1000hPa.TabIndex = 11;
            windDirection_1000hPa.Text = "{wind_direction_1000hPa.data} {wind_direction_1000hPa.unit}";
            windDirection_1000hPa.TextAlign = ContentAlignment.TopCenter;
            // 
            // windSpeed_1000hPa
            // 
            windSpeed_1000hPa.AutoSize = true;
            windSpeed_1000hPa.Dock = DockStyle.Fill;
            windSpeed_1000hPa.Location = new Point(477, 48);
            windSpeed_1000hPa.Margin = new Padding(3, 10, 3, 0);
            windSpeed_1000hPa.Name = "windSpeed_1000hPa";
            windSpeed_1000hPa.Size = new Size(131, 371);
            windSpeed_1000hPa.TabIndex = 10;
            windSpeed_1000hPa.Text = "{wind_speed_1000hPa.data} {wind_speed_1000hPa.unit}";
            windSpeed_1000hPa.TextAlign = ContentAlignment.TopCenter;
            // 
            // humidity_1000hPa
            // 
            humidity_1000hPa.AutoSize = true;
            humidity_1000hPa.Dock = DockStyle.Fill;
            humidity_1000hPa.Location = new Point(340, 48);
            humidity_1000hPa.Margin = new Padding(3, 10, 3, 0);
            humidity_1000hPa.Name = "humidity_1000hPa";
            humidity_1000hPa.Size = new Size(131, 371);
            humidity_1000hPa.TabIndex = 9;
            humidity_1000hPa.Text = "{relative_humidity_1000hPa.data} {relative_humidity_1000hPa.unit}";
            humidity_1000hPa.TextAlign = ContentAlignment.TopCenter;
            // 
            // temperature_1000hPa
            // 
            temperature_1000hPa.AutoSize = true;
            temperature_1000hPa.Dock = DockStyle.Fill;
            temperature_1000hPa.Location = new Point(203, 48);
            temperature_1000hPa.Margin = new Padding(3, 10, 3, 0);
            temperature_1000hPa.Name = "temperature_1000hPa";
            temperature_1000hPa.Size = new Size(131, 371);
            temperature_1000hPa.TabIndex = 8;
            temperature_1000hPa.Text = "{temperature_1000hPa.data} {temperature_1000hPa.unit}";
            temperature_1000hPa.TextAlign = ContentAlignment.TopCenter;
            // 
            // tableAtlitudeTitle
            // 
            tableAtlitudeTitle.AutoSize = true;
            tableAtlitudeTitle.Dock = DockStyle.Fill;
            tableAtlitudeTitle.Location = new Point(3, 0);
            tableAtlitudeTitle.Name = "tableAtlitudeTitle";
            tableAtlitudeTitle.Size = new Size(194, 38);
            tableAtlitudeTitle.TabIndex = 6;
            tableAtlitudeTitle.Text = "Atlitude";
            tableAtlitudeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableDirectionTitle
            // 
            tableDirectionTitle.AutoSize = true;
            tableDirectionTitle.Dock = DockStyle.Fill;
            tableDirectionTitle.Location = new Point(614, 0);
            tableDirectionTitle.Name = "tableDirectionTitle";
            tableDirectionTitle.Size = new Size(133, 38);
            tableDirectionTitle.TabIndex = 4;
            tableDirectionTitle.Text = "Wind direction";
            tableDirectionTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableSpeedTitle
            // 
            tableSpeedTitle.AutoSize = true;
            tableSpeedTitle.Dock = DockStyle.Fill;
            tableSpeedTitle.Location = new Point(477, 0);
            tableSpeedTitle.Name = "tableSpeedTitle";
            tableSpeedTitle.Size = new Size(131, 38);
            tableSpeedTitle.TabIndex = 3;
            tableSpeedTitle.Text = "Wind speed";
            tableSpeedTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableHumidityTitle
            // 
            tableHumidityTitle.AutoSize = true;
            tableHumidityTitle.Dock = DockStyle.Fill;
            tableHumidityTitle.Location = new Point(340, 0);
            tableHumidityTitle.Name = "tableHumidityTitle";
            tableHumidityTitle.Size = new Size(131, 38);
            tableHumidityTitle.TabIndex = 2;
            tableHumidityTitle.Text = "Relative humidity";
            tableHumidityTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableTempTitle
            // 
            tableTempTitle.AutoSize = true;
            tableTempTitle.Dock = DockStyle.Fill;
            tableTempTitle.Location = new Point(203, 0);
            tableTempTitle.Name = "tableTempTitle";
            tableTempTitle.Size = new Size(131, 38);
            tableTempTitle.TabIndex = 0;
            tableTempTitle.Text = "Temperature";
            tableTempTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // atlitude_1000hPa
            // 
            atlitude_1000hPa.AutoSize = true;
            atlitude_1000hPa.Dock = DockStyle.Fill;
            atlitude_1000hPa.Location = new Point(50, 48);
            atlitude_1000hPa.Margin = new Padding(50, 10, 3, 0);
            atlitude_1000hPa.Name = "atlitude_1000hPa";
            atlitude_1000hPa.Size = new Size(147, 371);
            atlitude_1000hPa.TabIndex = 5;
            atlitude_1000hPa.Text = resources.GetString("atlitude_1000hPa.Text");
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
            MaximizeBox = false;
            Name = "WeatherRider";
            Text = "Weather Rider";
            WindowState = FormWindowState.Minimized;
            generalData.ResumeLayout(false);
            generalData.PerformLayout();
            dailyData.ResumeLayout(false);
            dailyData.PerformLayout();
            windData.ResumeLayout(false);
            windData.PerformLayout();
            radiationData.ResumeLayout(false);
            radiationData.PerformLayout();
            altitudesData.ResumeLayout(false);
            altitudesDataTable.ResumeLayout(false);
            altitudesDataTable.PerformLayout();
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
        private TableLayoutPanel altitudesDataTable;
        private Label tableTempTitle;
        private Label tableDirectionTitle;
        private Label tableSpeedTitle;
        private Label tableHumidityTitle;
        private Label tableAtlitudeTitle;
        private Label windDirection_1000hPa;
        private Label windSpeed_1000hPa;
        private Label humidity_1000hPa;
        private Label temperature_1000hPa;
        private Label atlitude_1000hPa;
    }
}
