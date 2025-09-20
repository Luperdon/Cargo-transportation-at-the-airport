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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalLoadingTime = new System.Windows.Forms.Label();
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
            this.cbxSetDistributionStrategy = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.btnShowTerminalChart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(580, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество грузов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(580, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество самолётов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(580, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество взлётных полос:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(844, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Минимальный вес грузов:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(844, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Максимальный вес грузов:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(844, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Минимальное время погрузки на самолёт:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(844, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(327, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Максимальное время погрузки на самолёт:";
            // 
            // lblTotalLoadingTime
            // 
            this.lblTotalLoadingTime.AutoSize = true;
            this.lblTotalLoadingTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalLoadingTime.Location = new System.Drawing.Point(844, 507);
            this.lblTotalLoadingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLoadingTime.Name = "lblTotalLoadingTime";
            this.lblTotalLoadingTime.Size = new System.Drawing.Size(183, 20);
            this.lblTotalLoadingTime.TabIndex = 7;
            this.lblTotalLoadingTime.Text = "Общее время погрузки:";
            // 
            // lblUnloadedCargos
            // 
            this.lblUnloadedCargos.AutoSize = true;
            this.lblUnloadedCargos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUnloadedCargos.Location = new System.Drawing.Point(844, 541);
            this.lblUnloadedCargos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnloadedCargos.Name = "lblUnloadedCargos";
            this.lblUnloadedCargos.Size = new System.Drawing.Size(175, 20);
            this.lblUnloadedCargos.TabIndex = 8;
            this.lblUnloadedCargos.Text = "Незагруженные грузы:";
            // 
            // txtCargoCount
            // 
            this.txtCargoCount.Location = new System.Drawing.Point(581, 61);
            this.txtCargoCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCargoCount.Name = "txtCargoCount";
            this.txtCargoCount.Size = new System.Drawing.Size(100, 27);
            this.txtCargoCount.TabIndex = 9;
            // 
            // txtAirplaneCount
            // 
            this.txtAirplaneCount.Location = new System.Drawing.Point(581, 112);
            this.txtAirplaneCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAirplaneCount.Name = "txtAirplaneCount";
            this.txtAirplaneCount.Size = new System.Drawing.Size(100, 27);
            this.txtAirplaneCount.TabIndex = 10;
            // 
            // txtRunwayCount
            // 
            this.txtRunwayCount.Location = new System.Drawing.Point(581, 332);
            this.txtRunwayCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRunwayCount.Name = "txtRunwayCount";
            this.txtRunwayCount.Size = new System.Drawing.Size(100, 27);
            this.txtRunwayCount.TabIndex = 11;
            // 
            // txtMinCargoWeight
            // 
            this.txtMinCargoWeight.Location = new System.Drawing.Point(847, 61);
            this.txtMinCargoWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinCargoWeight.Name = "txtMinCargoWeight";
            this.txtMinCargoWeight.Size = new System.Drawing.Size(100, 27);
            this.txtMinCargoWeight.TabIndex = 12;
            // 
            // txtMaxCargoWeight
            // 
            this.txtMaxCargoWeight.Location = new System.Drawing.Point(847, 112);
            this.txtMaxCargoWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaxCargoWeight.Name = "txtMaxCargoWeight";
            this.txtMaxCargoWeight.Size = new System.Drawing.Size(100, 27);
            this.txtMaxCargoWeight.TabIndex = 13;
            // 
            // txtMinLoadingTime
            // 
            this.txtMinLoadingTime.Location = new System.Drawing.Point(847, 277);
            this.txtMinLoadingTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinLoadingTime.Name = "txtMinLoadingTime";
            this.txtMinLoadingTime.Size = new System.Drawing.Size(100, 27);
            this.txtMinLoadingTime.TabIndex = 14;
            // 
            // txtMaxLoadingTime
            // 
            this.txtMaxLoadingTime.Location = new System.Drawing.Point(847, 332);
            this.txtMaxLoadingTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaxLoadingTime.Name = "txtMaxLoadingTime";
            this.txtMaxLoadingTime.Size = new System.Drawing.Size(100, 27);
            this.txtMaxLoadingTime.TabIndex = 15;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(547, 566);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(580, 252);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(232, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Грузоподъёмность самолётов:";
            // 
            // txtLoadCapacityAirplane
            // 
            this.txtLoadCapacityAirplane.Location = new System.Drawing.Point(581, 276);
            this.txtLoadCapacityAirplane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLoadCapacityAirplane.Name = "txtLoadCapacityAirplane";
            this.txtLoadCapacityAirplane.Size = new System.Drawing.Size(100, 27);
            this.txtLoadCapacityAirplane.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(580, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Количество терминалов:";
            // 
            // txtTerminalCount
            // 
            this.txtTerminalCount.Location = new System.Drawing.Point(581, 166);
            this.txtTerminalCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTerminalCount.Name = "txtTerminalCount";
            this.txtTerminalCount.Size = new System.Drawing.Size(100, 27);
            this.txtTerminalCount.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(580, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Вместимость терминала:";
            // 
            // txtTerminalCapacity
            // 
            this.txtTerminalCapacity.Location = new System.Drawing.Point(581, 221);
            this.txtTerminalCapacity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTerminalCapacity.Name = "txtTerminalCapacity";
            this.txtTerminalCapacity.Size = new System.Drawing.Size(100, 27);
            this.txtTerminalCapacity.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(844, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(353, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Минимальное время обработки на терминале:";
            // 
            // txtMinProcessingTime
            // 
            this.txtMinProcessingTime.Location = new System.Drawing.Point(847, 166);
            this.txtMinProcessingTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMinProcessingTime.Name = "txtMinProcessingTime";
            this.txtMinProcessingTime.Size = new System.Drawing.Size(100, 27);
            this.txtMinProcessingTime.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(844, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(358, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Максимальное время обработки на терминале:";
            // 
            // txtMaxProcessingTime
            // 
            this.txtMaxProcessingTime.Location = new System.Drawing.Point(847, 221);
            this.txtMaxProcessingTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaxProcessingTime.Name = "txtMaxProcessingTime";
            this.txtMaxProcessingTime.Size = new System.Drawing.Size(100, 27);
            this.txtMaxProcessingTime.TabIndex = 27;
            // 
            // cbxSetDistributionStrategy
            // 
            this.cbxSetDistributionStrategy.FormattingEnabled = true;
            this.cbxSetDistributionStrategy.Items.AddRange(new object[] {
            "Последовательное",
            "Нормальное",
            "Экспоненциальное"});
            this.cbxSetDistributionStrategy.Location = new System.Drawing.Point(847, 456);
            this.cbxSetDistributionStrategy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxSetDistributionStrategy.Name = "cbxSetDistributionStrategy";
            this.cbxSetDistributionStrategy.Size = new System.Drawing.Size(175, 28);
            this.cbxSetDistributionStrategy.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(844, 432);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(398, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Выберите тип распределения грузов по терминалам:";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonStart.Location = new System.Drawing.Point(581, 409);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(167, 56);
            this.buttonStart.TabIndex = 30;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // btnShowTerminalChart
            // 
            this.btnShowTerminalChart.Location = new System.Drawing.Point(950, 620);
            this.btnShowTerminalChart.Name = "btnShowTerminalChart";
            this.btnShowTerminalChart.Size = new System.Drawing.Size(258, 28);
            this.btnShowTerminalChart.TabIndex = 31;
            this.btnShowTerminalChart.Text = "Статистика по терминалам";
            this.btnShowTerminalChart.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 28);
            this.button2.TabIndex = 32;
            this.button2.Text = "Статистика по полётам";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 687);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnShowTerminalChart);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbxSetDistributionStrategy);
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
            this.Controls.Add(this.lblTotalLoadingTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "Моделирование перевозки грузов в аэропорту";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Label lblTotalLoadingTime;
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
        private System.Windows.Forms.ComboBox cbxSetDistributionStrategy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button btnShowTerminalChart;
        private System.Windows.Forms.Button button2;
    }
}

