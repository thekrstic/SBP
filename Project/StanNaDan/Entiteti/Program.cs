using System;
using System.Windows.Forms;

namespace StanNaDan
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
            Application.Run(new PocetnaForma()); // Promenite 'Form1' ako je ime vaše forme drugačije
        }
    }
}
