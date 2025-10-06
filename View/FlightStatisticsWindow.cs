using CargoTransportationAtTheAirportF.Model;
using CargoTransportationAtTheAirportF.View.Interface;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CargoTransportationAtTheAirportF.View
{
    public partial class FlightStatisticsWindow : Form, IFlightWindow
    {
        public event Action ShowFlightsChartRequested;

        public FlightStatisticsWindow()
        {
            InitializeComponent();
        }

        public void ShowFlightsChart(List<Flight> flights)
        {
            chartFlights.Series.Clear();

            var series = new Series("Дистанция полётов (км)")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (var flight in flights)
            {
                series.Points.AddXY($"Рейс {flight._flightNumber}", flight._distance);
            }

            chartFlights.Series.Add(series);
        }

        private void btnShowFlightsChart_Click(object sender, EventArgs e)
        {
            ShowFlightsChartRequested?.Invoke();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
