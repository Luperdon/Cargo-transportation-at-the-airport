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

        public void ShowFlightsChart(List<Flight> flights, List<Airplane> allAirplanes)
        {
            chartFlights.Series.Clear();

            var series = new Series("Время полётов (часы)")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (var airplane in allAirplanes)
            {
                var flight = flights.Find(f => f._airplane == airplane);
                double distance = flight != null ? flight._flightTime : 0;

                series.Points.AddXY($"Самолёт {airplane._airplaneNumber}", distance);
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
