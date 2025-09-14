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
        public partial class MainWindow : Form, IView
        {
                public  IView _view { get; set; }
                public Chart _chart { get; set; }

                public event Action CreateAndDistributeCargoToTerminals;

                public int cargoCount => int.Parse(txtCargoCount.Text);
                public double minCargoWeight => double.Parse(txtMinCargoWeight.Text);
                public double maxCargoWeight => double.Parse(txtMaxCargoWeight.Text);

                public int terminalCount => int.Parse(txtTerminalCount.Text);
                public int terminalMaxCapacity => int.Parse(txtTerminalCapacity.Text);
                public double terminalMinProcessingTime => double.Parse(txtMinProcessingTime.Text);
                public double terminalMaxProcessingTime => double.Parse(txtMaxProcessingTime.Text);

                public string selectedStrategy => cbxSetDistributionStrategy.SelectedItem?.ToString() ?? "Последовательное";

                //lblUnloadedCargos.Text = $"Необработанных грузов: {presenter.UnprocessedCargoCount}";

                public MainWindow()
                {
                    InitializeComponent();

                    _chart = chart1; // ссылка на chart1 из дизайнера
                    _chart.ChartAreas.Clear();
                    _chart.ChartAreas.Add(new ChartArea("ChartArea1"));
                }

                public void ShowTerminalChart(List<Terminal> terminals)
                {
                    chart1.Series.Clear();
                    var series = new Series("Терминалы")
                    {
                        ChartType = SeriesChartType.Column
                    };

                    foreach (var terminal in terminals)
                    {
                        series.Points.AddXY(
                            $"T{terminal._terminalNumber}",
                            terminal._totalProcessingTime // или terminal._totalProcessedCargo
                        );
                    }

                    chart1.Series.Add(series);
                }

            private void buttonStart_Click(object sender, EventArgs e)
            {
                CreateAndDistributeCargoToTerminals?.Invoke();
            }
        }
}
