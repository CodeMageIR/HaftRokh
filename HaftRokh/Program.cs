using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaftRokh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var Task1 = Task.Factory.StartNew(() => Core.LoadHolidays());
            var Task2 = Task.Factory.StartNew(() => Core.LoadImportantDates());

            Task.WaitAll(Task1, Task2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
