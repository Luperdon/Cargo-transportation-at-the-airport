using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CargoTransportationAtTheAirportF.View;
using System.Windows.Forms.DataVisualization.Charting;
using CargoTransportationAtTheAirportF.Model;

namespace CargoTransportationAtTheAirportF
{
    public partial class MainWindow : Form, IMainView
    {
        public IMainView _view { get; set; }
        public Chart _chart { get; set; }

        public event Action CompleteDistribution;

        public event Action ShowFlightsWindow;
        public event Action ShowTerminalsWindow;
        public event Action ShowAboutWindow;

        public event Action SaveSettingsRequested;
        public event Action LoadSettingsRequested;
        //      ----------ГРУЗЫ----------
        public int cargoCount => int.Parse(txtCargoCount.Text);
        public double minCargoWeight => double.Parse(txtMinCargoWeight.Text);
        public double maxCargoWeight => double.Parse(txtMaxCargoWeight.Text);

        //      ----------САМОЛЁТЫ----------
        public int airplaneCount => int.Parse(txtAirplaneCount.Text);
        public double airplaneSpeed => double.Parse(txtAirplaneSpeed.Text);
        public double airplaneLoadCapacity => double.Parse(txtLoadCapacityAirplane.Text);
        public double minLoadingTime => double.Parse(txtMinLoadingTime.Text);
        public double maxLoadingTime => double.Parse(txtMaxLoadingTime.Text);
        public string selectedStrategyAirplanes => cbxSetDistributionStrategyAirplanes.SelectedItem?.ToString() ?? "Последовательное";

        //      ----------ТЕРМИНАЛЫ----------
        public int terminalCount => int.Parse(txtTerminalCount.Text);
        public int terminalMaxCapacity => int.Parse(txtTerminalCapacity.Text);
        public double minProcessingTime => double.Parse(txtMinProcessingTime.Text);
        public double maxProcessingTime => double.Parse(txtMaxProcessingTime.Text);
        public double maxPassableWeight => double.Parse(txtMaxPassableWeight.Text);
        public string selectedStrategyTerminals => cbxSetDistributionStrategyTerminals.SelectedItem?.ToString() ?? "Последовательное";

        //      ----------ПОЛОСЫ----------
        public int runwayCount => int.Parse(txtRunwayCount.Text);

        //      ----------ПОЛЁТЫ(ТОЧКИ)----------
        public int flightCount => int.Parse(txtFlightCount.Text);
        public double minDistance => double.Parse(txtMinDistance.Text);
        public double maxDistance => double.Parse(txtMaxDistance.Text);

        public MainWindow()
        {
            InitializeComponent();

            this.Icon = new Icon("flight_icon.ico");

            _chart = chart1; // ссылка на chart1 из дизайнера
            _chart.ChartAreas.Clear();
            _chart.ChartAreas.Add(new ChartArea("ChartArea1"));
        }

        public void ShowAirplaneChart(List<Airplane> airplanes)
        {
            chart1.Series.Clear();
            var series = new Series("Самолёты")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (var airplane in airplanes)
            {
                series.Points.AddXY(
                    $"С{airplane._airplaneNumber}",
                    airplane._currentLoad // или _totalFlightTime + airplane._totalLoadingTime
                );
            }

            chart1.Series.Add(series);
        }

        public void ShowCargoStatistics(int unprocessedCargo, int unloadedCargo, int brokenCargo)
        {
            lblUnprocessedCargos.Text = $"Необработанные грузы: {unprocessedCargo}";
            lblUnloadedCargos.Text = $"Незагруженные грузы: {unloadedCargo}";
            lblBrokenCargo.Text = $"Поломанные грузы при погрузке: {brokenCargo}";
        }

        public void ShowAverageTimes(double avgLoadingTime, double avgProcessingTime)
        {
            lblAverageLoadingTime.Text = $"Среднее время загрузки самолётов: {avgLoadingTime:F2} ч";
            lblAverageProcessingTime.Text = $"Среднее время обработки грузов: {avgProcessingTime:F2} ч";
        }


        public void SetCargoCount(string value) => txtCargoCount.Text = value;
        public void SetMinCargoWeight(string value) => txtMinCargoWeight.Text = value;
        public void SetMaxCargoWeight(string value) => txtMaxCargoWeight.Text = value;

        public void SetAirplaneCount(string value) => txtAirplaneCount.Text = value;
        public void SetAirplaneSpeed(string value) => txtAirplaneSpeed.Text = value;
        public void SetAirplaneLoadCapacity(string value) => txtLoadCapacityAirplane.Text = value;
        public void SetMinLoadingTime(string value) => txtMinLoadingTime.Text = value;
        public void SetMaxLoadingTime(string value) => txtMaxLoadingTime.Text = value;
        public void SetSelectedStrategyAirplanes(string value) => cbxSetDistributionStrategyAirplanes.SelectedItem = value;

        public void SetTerminalCount(string value) => txtTerminalCount.Text = value;
        public void SetTerminalMaxCapacity(string value) => txtTerminalCapacity.Text = value;
        public void SetMinProcessingTime(string value) => txtMinProcessingTime.Text = value;
        public void SetMaxProcessingTime(string value) => txtMaxProcessingTime.Text = value;
        public void SetMaxPassableWeight(string value) => txtMaxPassableWeight.Text = value;
        public void SetSelectedStrategyTerminals(string value) => cbxSetDistributionStrategyTerminals.SelectedItem = value;

        public void SetRunwayCount(string value) => txtRunwayCount.Text = value;

        public void SetFlightCount(string value) => txtFlightCount.Text = value;
        public void SetMinDistance(string value) => txtMinDistance.Text = value;
        public void SetMaxDistance(string value) => txtMaxDistance.Text = value;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            CompleteDistribution?.Invoke();
        }

        private void btnShowFlightWindow_Click(object sender, EventArgs e)
        {
            ShowFlightsWindow?.Invoke();
        }

        private void btnShowTerminalWindow_Click(object sender, EventArgs e)
        {
            ShowTerminalsWindow?.Invoke();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettingsRequested?.Invoke();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadSettingsRequested?.Invoke();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ShowAboutWindow?.Invoke();
        }
    }
}
