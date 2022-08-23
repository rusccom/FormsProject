using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppInstance.Run();
            if (AppInstance.mainForm != null)
            {
                System.Globalization.CultureInfo ci = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                if (ci.NumberFormat.NumberDecimalSeparator != ".")
                {
                    ci.NumberFormat.NumberDecimalSeparator = ".";
                    ci.NumberFormat.CurrencyDecimalSeparator = ".";
                    ci.DateTimeFormat.SetAllDateTimePatterns(new string[] { "d MMMM yyyy" } , 'Y');
                    System.Threading.Thread.CurrentThread.CurrentCulture = ci;
                }

                Application.Run(AppInstance.mainForm);
            }
        }
    }
}
