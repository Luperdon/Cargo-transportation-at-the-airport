namespace CargoTransportationAtTheAirportF.View
{
    partial class FlightStatisticsWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowFlightChart = new System.Windows.Forms.Button();
            this.btnCloseWindowFlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(453, 529);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "flightStatisticsChart";
            // 
            // btnShowFlightChart
            // 
            this.btnShowFlightChart.Location = new System.Drawing.Point(671, 126);
            this.btnShowFlightChart.Name = "btnShowFlightChart";
            this.btnShowFlightChart.Size = new System.Drawing.Size(208, 78);
            this.btnShowFlightChart.TabIndex = 1;
            this.btnShowFlightChart.Text = "Показать ";
            this.btnShowFlightChart.UseVisualStyleBackColor = true;
            // 
            // btnCloseWindowFlight
            // 
            this.btnCloseWindowFlight.Location = new System.Drawing.Point(671, 302);
            this.btnCloseWindowFlight.Name = "btnCloseWindowFlight";
            this.btnCloseWindowFlight.Size = new System.Drawing.Size(208, 78);
            this.btnCloseWindowFlight.TabIndex = 2;
            this.btnCloseWindowFlight.Text = "Закрыть";
            this.btnCloseWindowFlight.UseVisualStyleBackColor = true;
            // 
            // FlightStatisticsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnCloseWindowFlight);
            this.Controls.Add(this.btnShowFlightChart);
            this.Controls.Add(this.chart1);
            this.Name = "FlightStatisticsWindow";
            this.Text = "Статистика для полётов";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnShowFlightChart;
        private System.Windows.Forms.Button btnCloseWindowFlight;
    }
}