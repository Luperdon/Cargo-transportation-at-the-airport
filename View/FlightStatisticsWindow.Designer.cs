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
            this.chartFlights = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowFlightChart = new System.Windows.Forms.Button();
            this.btnCloseWindowFlight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFlights
            // 
            this.chartFlights.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chartArea1.Name = "ChartArea1";
            this.chartFlights.ChartAreas.Add(chartArea1);
            this.chartFlights.Cursor = System.Windows.Forms.Cursors.No;
            legend1.Name = "Legend1";
            this.chartFlights.Legends.Add(legend1);
            this.chartFlights.Location = new System.Drawing.Point(12, 12);
            this.chartFlights.Name = "chartFlights";
            this.chartFlights.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFlights.Series.Add(series1);
            this.chartFlights.Size = new System.Drawing.Size(453, 529);
            this.chartFlights.TabIndex = 0;
            this.chartFlights.Text = "flightStatisticsChart";
            // 
            // btnShowFlightChart
            // 
            this.btnShowFlightChart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnShowFlightChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShowFlightChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowFlightChart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnShowFlightChart.Location = new System.Drawing.Point(671, 126);
            this.btnShowFlightChart.Name = "btnShowFlightChart";
            this.btnShowFlightChart.Size = new System.Drawing.Size(208, 78);
            this.btnShowFlightChart.TabIndex = 1;
            this.btnShowFlightChart.Text = "Показать ";
            this.btnShowFlightChart.UseVisualStyleBackColor = false;
            this.btnShowFlightChart.Click += new System.EventHandler(this.btnShowFlightsChart_Click);
            // 
            // btnCloseWindowFlight
            // 
            this.btnCloseWindowFlight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCloseWindowFlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseWindowFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindowFlight.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnCloseWindowFlight.Location = new System.Drawing.Point(671, 302);
            this.btnCloseWindowFlight.Name = "btnCloseWindowFlight";
            this.btnCloseWindowFlight.Size = new System.Drawing.Size(208, 78);
            this.btnCloseWindowFlight.TabIndex = 2;
            this.btnCloseWindowFlight.Text = "Закрыть";
            this.btnCloseWindowFlight.UseVisualStyleBackColor = false;
            this.btnCloseWindowFlight.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // FlightStatisticsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.chartFlights);
            this.Controls.Add(this.btnCloseWindowFlight);
            this.Controls.Add(this.btnShowFlightChart);
            this.Name = "FlightStatisticsWindow";
            this.Text = "Статистика для полётов";
            ((System.ComponentModel.ISupportInitialize)(this.chartFlights)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFlights;
        private System.Windows.Forms.Button btnShowFlightChart;
        private System.Windows.Forms.Button btnCloseWindowFlight;
    }
}