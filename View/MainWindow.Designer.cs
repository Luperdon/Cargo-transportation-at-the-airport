namespace CargoTransportationAtTheAirportF
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAverageLoadingTime = new System.Windows.Forms.Label();
            this.lblUnloadedCargos = new System.Windows.Forms.Label();
            this.txtCargoCount = new System.Windows.Forms.TextBox();
            this.txtAirplaneCount = new System.Windows.Forms.TextBox();
            this.txtRunwayCount = new System.Windows.Forms.TextBox();
            this.txtMinCargoWeight = new System.Windows.Forms.TextBox();
            this.txtMaxCargoWeight = new System.Windows.Forms.TextBox();
            this.txtMinLoadingTime = new System.Windows.Forms.TextBox();
            this.txtMaxLoadingTime = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLoadCapacityAirplane = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTerminalCount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTerminalCapacity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMinProcessingTime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMaxProcessingTime = new System.Windows.Forms.TextBox();
            this.cbxSetDistributionStrategyTerminals = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.btnShowTerminalWindow = new System.Windows.Forms.Button();
            this.btnShowFlightWindow = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAirplaneSpeed = new System.Windows.Forms.TextBox();
            this.lblUnprocessedCargos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxSetDistributionStrategyAirplanes = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtFlightCount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMinDistance = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMaxDistance = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMaxPassableWeight = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblAverageProcessingTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(576, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество грузов:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(576, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество самолётов:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(573, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество взлётных полос:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(872, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Минимальный вес грузов (кг):";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(872, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Максимальный вес грузов (кг):";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(872, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Минимальное время погрузки на самолёт (ч):";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(871, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(352, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Максимальное время погрузки на самолёт (ч):";
            // 
            // lblAverageLoadingTime
            // 
            this.lblAverageLoadingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAverageLoadingTime.AutoSize = true;
            this.lblAverageLoadingTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAverageLoadingTime.Location = new System.Drawing.Point(1228, 87);
            this.lblAverageLoadingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverageLoadingTime.Name = "lblAverageLoadingTime";
            this.lblAverageLoadingTime.Size = new System.Drawing.Size(218, 20);
            this.lblAverageLoadingTime.TabIndex = 7;
            this.lblAverageLoadingTime.Text = "Среднее время погрузки (ч):";
            // 
            // lblUnloadedCargos
            // 
            this.lblUnloadedCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnloadedCargos.AutoSize = true;
            this.lblUnloadedCargos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnloadedCargos.Location = new System.Drawing.Point(1228, 61);
            this.lblUnloadedCargos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnloadedCargos.Name = "lblUnloadedCargos";
            this.lblUnloadedCargos.Size = new System.Drawing.Size(175, 20);
            this.lblUnloadedCargos.TabIndex = 8;
            this.lblUnloadedCargos.Text = "Незагруженные грузы:";
            // 
            // txtCargoCount
            // 
            this.txtCargoCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCargoCount.Location = new System.Drawing.Point(577, 61);
            this.txtCargoCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCargoCount.Name = "txtCargoCount";
            this.txtCargoCount.Size = new System.Drawing.Size(100, 27);
            this.txtCargoCount.TabIndex = 9;
            this.txtCargoCount.Text = "100";
            // 
            // txtAirplaneCount
            // 
            this.txtAirplaneCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAirplaneCount.Location = new System.Drawing.Point(577, 112);
            this.txtAirplaneCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAirplaneCount.Name = "txtAirplaneCount";
            this.txtAirplaneCount.Size = new System.Drawing.Size(100, 27);
            this.txtAirplaneCount.TabIndex = 10;
            this.txtAirplaneCount.Text = "10";
            // 
            // txtRunwayCount
            // 
            this.txtRunwayCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRunwayCount.Location = new System.Drawing.Point(574, 441);
            this.txtRunwayCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRunwayCount.Name = "txtRunwayCount";
            this.txtRunwayCount.Size = new System.Drawing.Size(100, 27);
            this.txtRunwayCount.TabIndex = 11;
            this.txtRunwayCount.Text = "10";
            // 
            // txtMinCargoWeight
            // 
            this.txtMinCargoWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMinCargoWeight.Location = new System.Drawing.Point(875, 61);
            this.txtMinCargoWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinCargoWeight.Name = "txtMinCargoWeight";
            this.txtMinCargoWeight.Size = new System.Drawing.Size(100, 27);
            this.txtMinCargoWeight.TabIndex = 12;
            this.txtMinCargoWeight.Text = "10";
            // 
            // txtMaxCargoWeight
            // 
            this.txtMaxCargoWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaxCargoWeight.Location = new System.Drawing.Point(875, 112);
            this.txtMaxCargoWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaxCargoWeight.Name = "txtMaxCargoWeight";
            this.txtMaxCargoWeight.Size = new System.Drawing.Size(100, 27);
            this.txtMaxCargoWeight.TabIndex = 13;
            this.txtMaxCargoWeight.Text = "50";
            // 
            // txtMinLoadingTime
            // 
            this.txtMinLoadingTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMinLoadingTime.Location = new System.Drawing.Point(875, 277);
            this.txtMinLoadingTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinLoadingTime.Name = "txtMinLoadingTime";
            this.txtMinLoadingTime.Size = new System.Drawing.Size(100, 27);
            this.txtMinLoadingTime.TabIndex = 14;
            this.txtMinLoadingTime.Text = "10";
            // 
            // txtMaxLoadingTime
            // 
            this.txtMaxLoadingTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaxLoadingTime.Location = new System.Drawing.Point(875, 332);
            this.txtMaxLoadingTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaxLoadingTime.Name = "txtMaxLoadingTime";
            this.txtMaxLoadingTime.Size = new System.Drawing.Size(100, 27);
            this.txtMaxLoadingTime.TabIndex = 15;
            this.txtMaxLoadingTime.Text = "20";
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Cursor = System.Windows.Forms.Cursors.No;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(13, 37);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(499, 513);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(577, 197);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(262, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Грузоподъёмность самолётов (кг):";
            // 
            // txtLoadCapacityAirplane
            // 
            this.txtLoadCapacityAirplane.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLoadCapacityAirplane.Location = new System.Drawing.Point(577, 221);
            this.txtLoadCapacityAirplane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLoadCapacityAirplane.Name = "txtLoadCapacityAirplane";
            this.txtLoadCapacityAirplane.Size = new System.Drawing.Size(100, 27);
            this.txtLoadCapacityAirplane.TabIndex = 19;
            this.txtLoadCapacityAirplane.Text = "20000";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(576, 254);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Количество терминалов:";
            // 
            // txtTerminalCount
            // 
            this.txtTerminalCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTerminalCount.Location = new System.Drawing.Point(577, 277);
            this.txtTerminalCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTerminalCount.Name = "txtTerminalCount";
            this.txtTerminalCount.Size = new System.Drawing.Size(100, 27);
            this.txtTerminalCount.TabIndex = 21;
            this.txtTerminalCount.Text = "5";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(573, 362);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(271, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Вместимость терминала (ед. груза):";
            // 
            // txtTerminalCapacity
            // 
            this.txtTerminalCapacity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTerminalCapacity.Location = new System.Drawing.Point(574, 386);
            this.txtTerminalCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTerminalCapacity.Name = "txtTerminalCapacity";
            this.txtTerminalCapacity.Size = new System.Drawing.Size(100, 27);
            this.txtTerminalCapacity.TabIndex = 23;
            this.txtTerminalCapacity.Text = "10";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(872, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(378, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Минимальное время обработки на терминале (ч):";
            // 
            // txtMinProcessingTime
            // 
            this.txtMinProcessingTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMinProcessingTime.Location = new System.Drawing.Point(875, 166);
            this.txtMinProcessingTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinProcessingTime.Name = "txtMinProcessingTime";
            this.txtMinProcessingTime.Size = new System.Drawing.Size(100, 27);
            this.txtMinProcessingTime.TabIndex = 25;
            this.txtMinProcessingTime.Text = "1";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(872, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(383, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Максимальное время обработки на терминале (ч):";
            // 
            // txtMaxProcessingTime
            // 
            this.txtMaxProcessingTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaxProcessingTime.Location = new System.Drawing.Point(875, 221);
            this.txtMaxProcessingTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaxProcessingTime.Name = "txtMaxProcessingTime";
            this.txtMaxProcessingTime.Size = new System.Drawing.Size(100, 27);
            this.txtMaxProcessingTime.TabIndex = 27;
            this.txtMaxProcessingTime.Text = "5";
            // 
            // cbxSetDistributionStrategyTerminals
            // 
            this.cbxSetDistributionStrategyTerminals.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSetDistributionStrategyTerminals.FormattingEnabled = true;
            this.cbxSetDistributionStrategyTerminals.Items.AddRange(new object[] {
            "Последовательное",
            "Нормальное",
            "Экспоненциальное"});
            this.cbxSetDistributionStrategyTerminals.Location = new System.Drawing.Point(838, 579);
            this.cbxSetDistributionStrategyTerminals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxSetDistributionStrategyTerminals.Name = "cbxSetDistributionStrategyTerminals";
            this.cbxSetDistributionStrategyTerminals.Size = new System.Drawing.Size(175, 28);
            this.cbxSetDistributionStrategyTerminals.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(835, 555);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(398, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Выберите тип распределения грузов по терминалам:";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(578, 555);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(167, 56);
            this.buttonStart.TabIndex = 30;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // btnShowTerminalWindow
            // 
            this.btnShowTerminalWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowTerminalWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnShowTerminalWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowTerminalWindow.Location = new System.Drawing.Point(269, 579);
            this.btnShowTerminalWindow.Name = "btnShowTerminalWindow";
            this.btnShowTerminalWindow.Size = new System.Drawing.Size(258, 28);
            this.btnShowTerminalWindow.TabIndex = 31;
            this.btnShowTerminalWindow.Text = "Статистика по терминалам";
            this.btnShowTerminalWindow.UseVisualStyleBackColor = false;
            this.btnShowTerminalWindow.Click += new System.EventHandler(this.btnShowTerminalWindow_Click);
            // 
            // btnShowFlightWindow
            // 
            this.btnShowFlightWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowFlightWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnShowFlightWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowFlightWindow.Location = new System.Drawing.Point(5, 579);
            this.btnShowFlightWindow.Name = "btnShowFlightWindow";
            this.btnShowFlightWindow.Size = new System.Drawing.Size(258, 28);
            this.btnShowFlightWindow.TabIndex = 32;
            this.btnShowFlightWindow.Text = "Статистика по полётам";
            this.btnShowFlightWindow.UseVisualStyleBackColor = false;
            this.btnShowFlightWindow.Click += new System.EventHandler(this.btnShowFlightWindow_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(576, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Скорость самолётов (км/ч):";
            // 
            // txtAirplaneSpeed
            // 
            this.txtAirplaneSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAirplaneSpeed.Location = new System.Drawing.Point(577, 166);
            this.txtAirplaneSpeed.Name = "txtAirplaneSpeed";
            this.txtAirplaneSpeed.Size = new System.Drawing.Size(100, 27);
            this.txtAirplaneSpeed.TabIndex = 34;
            this.txtAirplaneSpeed.Text = "240";
            // 
            // lblUnprocessedCargos
            // 
            this.lblUnprocessedCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnprocessedCargos.AutoSize = true;
            this.lblUnprocessedCargos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUnprocessedCargos.Location = new System.Drawing.Point(1228, 37);
            this.lblUnprocessedCargos.Name = "lblUnprocessedCargos";
            this.lblUnprocessedCargos.Size = new System.Drawing.Size(184, 20);
            this.lblUnprocessedCargos.TabIndex = 35;
            this.lblUnprocessedCargos.Text = "Необработанные грузы:";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(835, 610);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(387, 20);
            this.label16.TabIndex = 36;
            this.label16.Text = "Выберите тип распределения грузов по самолётам:";
            // 
            // cbxSetDistributionStrategyAirplanes
            // 
            this.cbxSetDistributionStrategyAirplanes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxSetDistributionStrategyAirplanes.FormattingEnabled = true;
            this.cbxSetDistributionStrategyAirplanes.Items.AddRange(new object[] {
            "Последовательное",
            "Нормальное",
            "Экспоненциальное"});
            this.cbxSetDistributionStrategyAirplanes.Location = new System.Drawing.Point(838, 629);
            this.cbxSetDistributionStrategyAirplanes.Name = "cbxSetDistributionStrategyAirplanes";
            this.cbxSetDistributionStrategyAirplanes.Size = new System.Drawing.Size(175, 28);
            this.cbxSetDistributionStrategyAirplanes.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(573, 471);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 20);
            this.label17.TabIndex = 38;
            this.label17.Text = "Количество точек:";
            // 
            // txtFlightCount
            // 
            this.txtFlightCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFlightCount.Location = new System.Drawing.Point(574, 494);
            this.txtFlightCount.Name = "txtFlightCount";
            this.txtFlightCount.Size = new System.Drawing.Size(100, 27);
            this.txtFlightCount.TabIndex = 39;
            this.txtFlightCount.Text = "10";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(871, 360);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(288, 20);
            this.label18.TabIndex = 40;
            this.label18.Text = "Минимальная дистанция полёта (км):";
            // 
            // txtMinDistance
            // 
            this.txtMinDistance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMinDistance.Location = new System.Drawing.Point(875, 383);
            this.txtMinDistance.Name = "txtMinDistance";
            this.txtMinDistance.Size = new System.Drawing.Size(100, 27);
            this.txtMinDistance.TabIndex = 41;
            this.txtMinDistance.Text = "3600";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(871, 417);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(293, 20);
            this.label19.TabIndex = 42;
            this.label19.Text = "Максимальная дистанция полёта (км):";
            // 
            // txtMaxDistance
            // 
            this.txtMaxDistance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaxDistance.Location = new System.Drawing.Point(875, 440);
            this.txtMaxDistance.Name = "txtMaxDistance";
            this.txtMaxDistance.Size = new System.Drawing.Size(100, 27);
            this.txtMaxDistance.TabIndex = 43;
            this.txtMaxDistance.Text = "7200";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(577, 309);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(286, 20);
            this.label20.TabIndex = 44;
            this.label20.Text = "Ограничение веса единицы груза (кг):";
            // 
            // txtMaxPassableWeight
            // 
            this.txtMaxPassableWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaxPassableWeight.Location = new System.Drawing.Point(577, 332);
            this.txtMaxPassableWeight.Name = "txtMaxPassableWeight";
            this.txtMaxPassableWeight.Size = new System.Drawing.Size(100, 27);
            this.txtMaxPassableWeight.TabIndex = 45;
            this.txtMaxPassableWeight.Text = "1000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1033, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1621, 37);
            this.panel1.TabIndex = 47;
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInfo.Location = new System.Drawing.Point(1478, 3);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.TabIndex = 50;
            this.btnInfo.Text = "?";
            this.btnInfo.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(887, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Программа для моделирования работы аэропорта (управление перевозкой грузов)";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(1269, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 56);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Location = new System.Drawing.Point(1269, 601);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(167, 56);
            this.btnLoad.TabIndex = 49;
            this.btnLoad.Text = "Загрузить";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblAverageProcessingTime
            // 
            this.lblAverageProcessingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAverageProcessingTime.AutoSize = true;
            this.lblAverageProcessingTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAverageProcessingTime.Location = new System.Drawing.Point(1228, 115);
            this.lblAverageProcessingTime.Name = "lblAverageProcessingTime";
            this.lblAverageProcessingTime.Size = new System.Drawing.Size(230, 20);
            this.lblAverageProcessingTime.TabIndex = 50;
            this.lblAverageProcessingTime.Text = "Среднее время обработки (ч):";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 714);
            this.Controls.Add(this.lblAverageProcessingTime);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMaxPassableWeight);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtMaxDistance);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtMinDistance);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtFlightCount);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbxSetDistributionStrategyAirplanes);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblUnprocessedCargos);
            this.Controls.Add(this.txtAirplaneSpeed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnShowFlightWindow);
            this.Controls.Add(this.btnShowTerminalWindow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbxSetDistributionStrategyTerminals);
            this.Controls.Add(this.txtMaxProcessingTime);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMinProcessingTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTerminalCapacity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTerminalCount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLoadCapacityAirplane);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtMaxLoadingTime);
            this.Controls.Add(this.txtMinLoadingTime);
            this.Controls.Add(this.txtMaxCargoWeight);
            this.Controls.Add(this.txtMinCargoWeight);
            this.Controls.Add(this.txtRunwayCount);
            this.Controls.Add(this.txtAirplaneCount);
            this.Controls.Add(this.txtCargoCount);
            this.Controls.Add(this.lblUnloadedCargos);
            this.Controls.Add(this.lblAverageLoadingTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "Моделирование перевозки грузов в аэропорту";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAverageLoadingTime;
        private System.Windows.Forms.Label lblUnloadedCargos;
        private System.Windows.Forms.TextBox txtCargoCount;
        private System.Windows.Forms.TextBox txtAirplaneCount;
        private System.Windows.Forms.TextBox txtRunwayCount;
        private System.Windows.Forms.TextBox txtMinCargoWeight;
        private System.Windows.Forms.TextBox txtMaxCargoWeight;
        private System.Windows.Forms.TextBox txtMinLoadingTime;
        private System.Windows.Forms.TextBox txtMaxLoadingTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoadCapacityAirplane;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTerminalCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTerminalCapacity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMinProcessingTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMaxProcessingTime;
        private System.Windows.Forms.ComboBox cbxSetDistributionStrategyTerminals;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button btnShowTerminalWindow;
        private System.Windows.Forms.Button btnShowFlightWindow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAirplaneSpeed;
        private System.Windows.Forms.Label lblUnprocessedCargos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxSetDistributionStrategyAirplanes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtFlightCount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMinDistance;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMaxDistance;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtMaxPassableWeight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblAverageProcessingTime;
    }
}

