namespace CargoTransportationAtTheAirportF.View
{
    partial class TerminalStatisticsWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTerminals = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowTerminalChart = new System.Windows.Forms.Button();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTerminals)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTerminals
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTerminals.ChartAreas.Add(chartArea2);
            this.chartTerminals.Cursor = System.Windows.Forms.Cursors.No;
            legend2.Name = "Legend1";
            this.chartTerminals.Legends.Add(legend2);
            this.chartTerminals.Location = new System.Drawing.Point(12, 12);
            this.chartTerminals.Name = "chartTerminals";
            this.chartTerminals.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTerminals.Series.Add(series2);
            this.chartTerminals.Size = new System.Drawing.Size(453, 529);
            this.chartTerminals.TabIndex = 0;
            this.chartTerminals.Text = "chart1";
            // 
            // btnShowTerminalChart
            // 
            this.btnShowTerminalChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnShowTerminalChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowTerminalChart.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnShowTerminalChart.Location = new System.Drawing.Point(671, 126);
            this.btnShowTerminalChart.Name = "btnShowTerminalChart";
            this.btnShowTerminalChart.Size = new System.Drawing.Size(208, 78);
            this.btnShowTerminalChart.TabIndex = 1;
            this.btnShowTerminalChart.Text = "Показать";
            this.btnShowTerminalChart.UseVisualStyleBackColor = false;
            this.btnShowTerminalChart.Click += new System.EventHandler(this.btnShowTerminalChart_Click);
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseWindow.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCloseWindow.Location = new System.Drawing.Point(671, 302);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(208, 78);
            this.btnCloseWindow.TabIndex = 2;
            this.btnCloseWindow.Text = "Закрыть";
            this.btnCloseWindow.UseVisualStyleBackColor = false;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // TerminalStatisticsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnCloseWindow);
            this.Controls.Add(this.btnShowTerminalChart);
            this.Controls.Add(this.chartTerminals);
            this.Name = "TerminalStatisticsWindow";
            this.Text = "Статистика для терминалов";
            ((System.ComponentModel.ISupportInitialize)(this.chartTerminals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTerminals;
        private System.Windows.Forms.Button btnShowTerminalChart;
        private System.Windows.Forms.Button btnCloseWindow;
    }
}