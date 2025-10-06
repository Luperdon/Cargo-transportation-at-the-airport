using CargoTransportationAtTheAirportF.Model;
using CargoTransportationAtTheAirportF.View.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CargoTransportationAtTheAirportF.View
{
    public partial class TerminalStatisticsWindow : Form, ITerminalWindow
    {
        public event Action ShowTerminalChartRequested;
        public event Action CloseRequested;

        public TerminalStatisticsWindow()
        {
            InitializeComponent();
        }

        public void ShowTerminalsChart(List<Terminal> terminals)
        {
            chartTerminals.Series.Clear();

            var series = new Series("Грузов обработано")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (var terminal in terminals)
            {
                series.Points.AddXY(terminal._terminalNumber, terminal._totalProcessedCargo);
            }

            chartTerminals.Series.Add(series);
        }

        private void btnShowTerminalChart_Click(object sender, EventArgs e)
        {
            ShowTerminalChartRequested?.Invoke();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
