namespace Task1_19003041_PROG6211
{
    partial class WeatherForecaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForecaster));
            this.cityBox = new System.Windows.Forms.ComboBox();
            this.minTempBox = new System.Windows.Forms.TextBox();
            this.maxTempBox = new System.Windows.Forms.TextBox();
            this.precipBox = new System.Windows.Forms.TextBox();
            this.humidBox = new System.Windows.Forms.TextBox();
            this.windBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.minTempLabel = new System.Windows.Forms.Label();
            this.maxTempLabel = new System.Windows.Forms.Label();
            this.precipLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.dateInputBox = new System.Windows.Forms.DateTimePicker();
            this.reportLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lowestMaxTemp = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.highestMaxTemp = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.highestWind = new System.Windows.Forms.Label();
            this.highestHumid = new System.Windows.Forms.Label();
            this.highestPrecip = new System.Windows.Forms.Label();
            this.highestMinTemp = new System.Windows.Forms.Label();
            this.lowestWind = new System.Windows.Forms.Label();
            this.lowestHumid = new System.Windows.Forms.Label();
            this.lowestPrecip = new System.Windows.Forms.Label();
            this.lowestMinTemp = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.reportTable = new System.Windows.Forms.DataGridView();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precipitation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WindSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.datesSelected = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.endDateBox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateBox = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cityReportBox = new System.Windows.Forms.TextBox();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.clearCitiesSelected = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cityBox
            // 
            this.cityBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Alexandra",
            "Bellville",
            "Benoni",
            "Bloemfontein",
            "Boksburg",
            "Botshabelo",
            "Cape Town",
            "Chatsworth",
            "Durban",
            "East London",
            "Empangeni",
            "Germiston",
            "Johannesburg",
            "Katlehong",
            "Kempton Park",
            "Khayelitsha",
            "Kimberley",
            "KwaMashu",
            "Newcastle",
            "Ntuzuma",
            "Pietermaritzburg",
            "Port Elizabeth",
            "Pretoria",
            "Roodepoort",
            "Springs",
            "Tembisa",
            "Umlazi",
            "Vereeniging"});
            this.cityBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cityBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cityBox.Items.AddRange(new object[] {
            "Alexandra",
            "Bellville",
            "Benoni",
            "Bloemfontein",
            "Boksburg",
            "Botshabelo",
            "Cape Town",
            "Chatsworth",
            "Durban",
            "East London",
            "Empangeni",
            "Germiston",
            "Johannesburg",
            "Katlehong",
            "Kempton Park",
            "Khayelitsha",
            "Kimberley",
            "KwaMashu",
            "Newcastle",
            "Ntuzuma",
            "Pietermaritzburg",
            "Port Elizabeth",
            "Pretoria",
            "Roodepoort",
            "Springs",
            "Tembisa",
            "Umlazi",
            "Vereeniging"});
            this.cityBox.Location = new System.Drawing.Point(98, 110);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(157, 21);
            this.cityBox.TabIndex = 0;
            this.cityBox.Text = "Cape Town";
            this.cityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityBox_KeyPress);
            // 
            // minTempBox
            // 
            this.minTempBox.Location = new System.Drawing.Point(98, 162);
            this.minTempBox.MaxLength = 3;
            this.minTempBox.Name = "minTempBox";
            this.minTempBox.Size = new System.Drawing.Size(39, 20);
            this.minTempBox.TabIndex = 2;
            this.minTempBox.Text = "56";
            this.minTempBox.TextChanged += new System.EventHandler(this.minTempBox_TextChanged);
            this.minTempBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinTempBox_KeyPress);
            // 
            // maxTempBox
            // 
            this.maxTempBox.Location = new System.Drawing.Point(98, 188);
            this.maxTempBox.MaxLength = 3;
            this.maxTempBox.Name = "maxTempBox";
            this.maxTempBox.Size = new System.Drawing.Size(39, 20);
            this.maxTempBox.TabIndex = 3;
            this.maxTempBox.Text = "56";
            this.maxTempBox.TextChanged += new System.EventHandler(this.maxTempBox_TextChanged);
            this.maxTempBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaxTempBox_KeyPress);
            // 
            // precipBox
            // 
            this.precipBox.Location = new System.Drawing.Point(98, 214);
            this.precipBox.MaxLength = 3;
            this.precipBox.Name = "precipBox";
            this.precipBox.Size = new System.Drawing.Size(39, 20);
            this.precipBox.TabIndex = 4;
            this.precipBox.Text = "56";
            this.precipBox.TextChanged += new System.EventHandler(this.PrecipBox_TextChanged);
            this.precipBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecipBox_KeyPress);
            // 
            // humidBox
            // 
            this.humidBox.Location = new System.Drawing.Point(98, 240);
            this.humidBox.MaxLength = 3;
            this.humidBox.Name = "humidBox";
            this.humidBox.Size = new System.Drawing.Size(39, 20);
            this.humidBox.TabIndex = 5;
            this.humidBox.Text = "56";
            this.humidBox.TextChanged += new System.EventHandler(this.humidBox_TextChanged);
            this.humidBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HumidBox_KeyPress);
            // 
            // windBox
            // 
            this.windBox.Location = new System.Drawing.Point(98, 266);
            this.windBox.MaxLength = 3;
            this.windBox.Name = "windBox";
            this.windBox.Size = new System.Drawing.Size(39, 20);
            this.windBox.TabIndex = 6;
            this.windBox.Text = "56";
            this.windBox.TextChanged += new System.EventHandler(this.windBox_TextChanged);
            this.windBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WindBox_KeyPress);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.Transparent;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(60, 113);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(32, 13);
            this.cityLabel.TabIndex = 7;
            this.cityLabel.Text = "City:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(54, 139);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 13);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Date:";
            // 
            // minTempLabel
            // 
            this.minTempLabel.AutoSize = true;
            this.minTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.minTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTempLabel.Location = new System.Drawing.Point(26, 165);
            this.minTempLabel.Name = "minTempLabel";
            this.minTempLabel.Size = new System.Drawing.Size(66, 13);
            this.minTempLabel.TabIndex = 9;
            this.minTempLabel.Text = "Min Temp:";
            // 
            // maxTempLabel
            // 
            this.maxTempLabel.AutoSize = true;
            this.maxTempLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTempLabel.Location = new System.Drawing.Point(23, 191);
            this.maxTempLabel.Name = "maxTempLabel";
            this.maxTempLabel.Size = new System.Drawing.Size(69, 13);
            this.maxTempLabel.TabIndex = 10;
            this.maxTempLabel.Text = "Max Temp:";
            // 
            // precipLabel
            // 
            this.precipLabel.AutoSize = true;
            this.precipLabel.BackColor = System.Drawing.Color.Transparent;
            this.precipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precipLabel.Location = new System.Drawing.Point(10, 217);
            this.precipLabel.Name = "precipLabel";
            this.precipLabel.Size = new System.Drawing.Size(82, 13);
            this.precipLabel.TabIndex = 11;
            this.precipLabel.Text = "Precipitation:";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.Location = new System.Drawing.Point(33, 243);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(59, 13);
            this.humidityLabel.TabIndex = 12;
            this.humidityLabel.Text = "Humidity:";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedLabel.Location = new System.Drawing.Point(12, 269);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.Size = new System.Drawing.Size(80, 13);
            this.windSpeedLabel.TabIndex = 13;
            this.windSpeedLabel.Text = "Wind Speed:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(180, 306);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dateInputBox
            // 
            this.dateInputBox.Location = new System.Drawing.Point(98, 136);
            this.dateInputBox.Name = "dateInputBox";
            this.dateInputBox.Size = new System.Drawing.Size(200, 20);
            this.dateInputBox.TabIndex = 15;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.BackColor = System.Drawing.Color.Transparent;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(91, 24);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(140, 39);
            this.reportLabel.TabIndex = 19;
            this.reportLabel.Text = "Capture";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(140, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "°C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(140, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "°C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(143, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(143, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(143, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "km/h";
            // 
            // lowestMaxTemp
            // 
            this.lowestMaxTemp.AutoSize = true;
            this.lowestMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.lowestMaxTemp.Location = new System.Drawing.Point(723, 493);
            this.lowestMaxTemp.Name = "lowestMaxTemp";
            this.lowestMaxTemp.Size = new System.Drawing.Size(0, 13);
            this.lowestMaxTemp.TabIndex = 128;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(656, 493);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 127;
            this.label23.Text = "Max Temp:";
            // 
            // highestMaxTemp
            // 
            this.highestMaxTemp.AutoSize = true;
            this.highestMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.highestMaxTemp.Location = new System.Drawing.Point(906, 493);
            this.highestMaxTemp.Name = "highestMaxTemp";
            this.highestMaxTemp.Size = new System.Drawing.Size(0, 13);
            this.highestMaxTemp.TabIndex = 126;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(840, 493);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 125;
            this.label21.Text = "Max Temp:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(843, 469);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(57, 13);
            this.label22.TabIndex = 124;
            this.label22.Text = "Min Temp:";
            // 
            // highestWind
            // 
            this.highestWind.AutoSize = true;
            this.highestWind.BackColor = System.Drawing.Color.Transparent;
            this.highestWind.Location = new System.Drawing.Point(906, 567);
            this.highestWind.Name = "highestWind";
            this.highestWind.Size = new System.Drawing.Size(0, 13);
            this.highestWind.TabIndex = 123;
            // 
            // highestHumid
            // 
            this.highestHumid.AutoSize = true;
            this.highestHumid.BackColor = System.Drawing.Color.Transparent;
            this.highestHumid.Location = new System.Drawing.Point(906, 542);
            this.highestHumid.Name = "highestHumid";
            this.highestHumid.Size = new System.Drawing.Size(0, 13);
            this.highestHumid.TabIndex = 122;
            // 
            // highestPrecip
            // 
            this.highestPrecip.AutoSize = true;
            this.highestPrecip.BackColor = System.Drawing.Color.Transparent;
            this.highestPrecip.Location = new System.Drawing.Point(906, 517);
            this.highestPrecip.Name = "highestPrecip";
            this.highestPrecip.Size = new System.Drawing.Size(0, 13);
            this.highestPrecip.TabIndex = 121;
            // 
            // highestMinTemp
            // 
            this.highestMinTemp.AutoSize = true;
            this.highestMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.highestMinTemp.Location = new System.Drawing.Point(906, 469);
            this.highestMinTemp.Name = "highestMinTemp";
            this.highestMinTemp.Size = new System.Drawing.Size(0, 13);
            this.highestMinTemp.TabIndex = 120;
            // 
            // lowestWind
            // 
            this.lowestWind.AutoSize = true;
            this.lowestWind.BackColor = System.Drawing.Color.Transparent;
            this.lowestWind.Location = new System.Drawing.Point(723, 567);
            this.lowestWind.Name = "lowestWind";
            this.lowestWind.Size = new System.Drawing.Size(0, 13);
            this.lowestWind.TabIndex = 119;
            // 
            // lowestHumid
            // 
            this.lowestHumid.AutoSize = true;
            this.lowestHumid.BackColor = System.Drawing.Color.Transparent;
            this.lowestHumid.Location = new System.Drawing.Point(723, 542);
            this.lowestHumid.Name = "lowestHumid";
            this.lowestHumid.Size = new System.Drawing.Size(0, 13);
            this.lowestHumid.TabIndex = 118;
            // 
            // lowestPrecip
            // 
            this.lowestPrecip.AutoSize = true;
            this.lowestPrecip.BackColor = System.Drawing.Color.Transparent;
            this.lowestPrecip.Location = new System.Drawing.Point(723, 517);
            this.lowestPrecip.Name = "lowestPrecip";
            this.lowestPrecip.Size = new System.Drawing.Size(0, 13);
            this.lowestPrecip.TabIndex = 117;
            // 
            // lowestMinTemp
            // 
            this.lowestMinTemp.AutoSize = true;
            this.lowestMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.lowestMinTemp.Location = new System.Drawing.Point(723, 469);
            this.lowestMinTemp.Name = "lowestMinTemp";
            this.lowestMinTemp.Size = new System.Drawing.Size(0, 13);
            this.lowestMinTemp.TabIndex = 116;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(831, 567);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 115;
            this.label18.Text = "Wind Speed:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(850, 542);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 114;
            this.label19.Text = "Humidity:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(832, 517);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 113;
            this.label20.Text = "Precipitation:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(647, 567);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 112;
            this.label17.Text = "Wind Speed:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(666, 542);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 111;
            this.label15.Text = "Humidity:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(648, 517);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 110;
            this.label16.Text = "Precipitation:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(659, 469);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 109;
            this.label14.Text = "Min Temp:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(835, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 18);
            this.label13.TabIndex = 108;
            this.label13.Text = "Highest";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(654, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 107;
            this.label12.Text = "Lowest";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(415, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 13);
            this.label11.TabIndex = 106;
            this.label11.Text = "Add or Remove Cities:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(473, 326);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 105;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // reportTable
            // 
            this.reportTable.AllowUserToAddRows = false;
            this.reportTable.AllowUserToDeleteRows = false;
            this.reportTable.AllowUserToResizeColumns = false;
            this.reportTable.AllowUserToResizeRows = false;
            this.reportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City,
            this.Date,
            this.MinTemp,
            this.MaxTemp,
            this.Precipitation,
            this.Humidity,
            this.WindSpeed});
            this.reportTable.Location = new System.Drawing.Point(643, 201);
            this.reportTable.Name = "reportTable";
            this.reportTable.ReadOnly = true;
            this.reportTable.Size = new System.Drawing.Size(574, 222);
            this.reportTable.TabIndex = 104;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // MinTemp
            // 
            this.MinTemp.HeaderText = "Min Temp (°C)";
            this.MinTemp.MaxInputLength = 3;
            this.MinTemp.MinimumWidth = 3;
            this.MinTemp.Name = "MinTemp";
            this.MinTemp.ReadOnly = true;
            this.MinTemp.Width = 65;
            // 
            // MaxTemp
            // 
            this.MaxTemp.HeaderText = "Max Temp  (°C)";
            this.MaxTemp.MaxInputLength = 3;
            this.MaxTemp.MinimumWidth = 3;
            this.MaxTemp.Name = "MaxTemp";
            this.MaxTemp.ReadOnly = true;
            this.MaxTemp.Width = 65;
            // 
            // Precipitation
            // 
            this.Precipitation.HeaderText = "Precipitation (%)";
            this.Precipitation.MaxInputLength = 3;
            this.Precipitation.MinimumWidth = 3;
            this.Precipitation.Name = "Precipitation";
            this.Precipitation.ReadOnly = true;
            this.Precipitation.Width = 75;
            // 
            // Humidity
            // 
            this.Humidity.HeaderText = "Humidity (%)";
            this.Humidity.MaxInputLength = 3;
            this.Humidity.MinimumWidth = 3;
            this.Humidity.Name = "Humidity";
            this.Humidity.ReadOnly = true;
            this.Humidity.Width = 55;
            // 
            // WindSpeed
            // 
            this.WindSpeed.HeaderText = "Wind Speed (km/h)";
            this.WindSpeed.MaxInputLength = 3;
            this.WindSpeed.MinimumWidth = 3;
            this.WindSpeed.Name = "WindSpeed";
            this.WindSpeed.ReadOnly = true;
            this.WindSpeed.Width = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(719, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 39);
            this.label6.TabIndex = 103;
            this.label6.Text = "Report";
            // 
            // datesSelected
            // 
            this.datesSelected.AutoSize = true;
            this.datesSelected.BackColor = System.Drawing.Color.Transparent;
            this.datesSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datesSelected.Location = new System.Drawing.Point(765, 171);
            this.datesSelected.Name = "datesSelected";
            this.datesSelected.Size = new System.Drawing.Size(139, 16);
            this.datesSelected.TabIndex = 102;
            this.datesSelected.Text = "1/01/2020 - 30/09/2020";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 101;
            this.label4.Text = "Dates Selected:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Ending Date:";
            // 
            // endDateBox
            // 
            this.endDateBox.Location = new System.Drawing.Point(418, 269);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(211, 20);
            this.endDateBox.TabIndex = 99;
            this.endDateBox.Value = new System.DateTime(2020, 9, 30, 0, 0, 0, 0);
            this.endDateBox.ValueChanged += new System.EventHandler(this.endDateBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Starting Date:";
            // 
            // startDateBox
            // 
            this.startDateBox.Location = new System.Drawing.Point(418, 195);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(211, 20);
            this.startDateBox.TabIndex = 97;
            this.startDateBox.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.startDateBox.ValueChanged += new System.EventHandler(this.startDateBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 96;
            this.label1.Text = "Cities Selected:";
            // 
            // cityReportBox
            // 
            this.cityReportBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityReportBox.Location = new System.Drawing.Point(761, 112);
            this.cityReportBox.MaximumSize = new System.Drawing.Size(400, 4);
            this.cityReportBox.MinimumSize = new System.Drawing.Size(400, 39);
            this.cityReportBox.Multiline = true;
            this.cityReportBox.Name = "cityReportBox";
            this.cityReportBox.ReadOnly = true;
            this.cityReportBox.Size = new System.Drawing.Size(400, 39);
            this.cityReportBox.TabIndex = 95;
            this.cityReportBox.Text = "Cape Town, Johannesburg";
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(418, 121);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(211, 21);
            this.cityComboBox.TabIndex = 94;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(68, 306);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 129;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // clearCitiesSelected
            // 
            this.clearCitiesSelected.Location = new System.Drawing.Point(1167, 121);
            this.clearCitiesSelected.Name = "clearCitiesSelected";
            this.clearCitiesSelected.Size = new System.Drawing.Size(46, 23);
            this.clearCitiesSelected.TabIndex = 130;
            this.clearCitiesSelected.Text = "Clear";
            this.clearCitiesSelected.UseVisualStyleBackColor = true;
            this.clearCitiesSelected.Click += new System.EventHandler(this.clearCitiesSelected_Click);
            // 
            // WeatherForecaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1224, 597);
            this.Controls.Add(this.clearCitiesSelected);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.lowestMaxTemp);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.highestMaxTemp);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.highestWind);
            this.Controls.Add(this.highestHumid);
            this.Controls.Add(this.highestPrecip);
            this.Controls.Add(this.highestMinTemp);
            this.Controls.Add(this.lowestWind);
            this.Controls.Add(this.lowestHumid);
            this.Controls.Add(this.lowestPrecip);
            this.Controls.Add(this.lowestMinTemp);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.reportTable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datesSelected);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endDateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityReportBox);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.dateInputBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.precipLabel);
            this.Controls.Add(this.maxTempLabel);
            this.Controls.Add(this.minTempLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.windBox);
            this.Controls.Add(this.humidBox);
            this.Controls.Add(this.precipBox);
            this.Controls.Add(this.maxTempBox);
            this.Controls.Add(this.minTempBox);
            this.Controls.Add(this.cityBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherForecaster";
            this.Text = "Weather Forecaster";
            this.Load += new System.EventHandler(this.WeatherForecaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cityBox;
        private System.Windows.Forms.TextBox minTempBox;
        private System.Windows.Forms.TextBox maxTempBox;
        private System.Windows.Forms.TextBox precipBox;
        private System.Windows.Forms.TextBox humidBox;
        private System.Windows.Forms.TextBox windBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label minTempLabel;
        private System.Windows.Forms.Label maxTempLabel;
        private System.Windows.Forms.Label precipLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker dateInputBox;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lowestMaxTemp;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label highestMaxTemp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label highestWind;
        private System.Windows.Forms.Label highestHumid;
        private System.Windows.Forms.Label highestPrecip;
        private System.Windows.Forms.Label highestMinTemp;
        private System.Windows.Forms.Label lowestWind;
        private System.Windows.Forms.Label lowestHumid;
        private System.Windows.Forms.Label lowestPrecip;
        private System.Windows.Forms.Label lowestMinTemp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView reportTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precipitation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn WindSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label datesSelected;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDateBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityReportBox;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button clearCitiesSelected;
    }
}

