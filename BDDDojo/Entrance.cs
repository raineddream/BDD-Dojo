using System;
using System.Windows.Forms;
using Rain.BDDDojo.ParkingCost;

namespace Rain.BDDDojo
{
    static class Entrance
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ParkingCostCalculator());
        }
    }
}
