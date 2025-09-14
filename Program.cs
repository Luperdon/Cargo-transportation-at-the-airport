using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CargoTransportationAtTheAirportF.Presenter;

namespace CargoTransportationAtTheAirportF
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new MainWindow();
            var presenter = new MainPresenter(form);

            Application.Run(form);
        }
    }
}
