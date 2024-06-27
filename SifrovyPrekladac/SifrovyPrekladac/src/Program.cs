using SifrovyPrekladac.src;
using SifrovyPrekladac.src.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifrovyPrekladac
{
    internal static class Program
    {
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool error = false;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                ProgramInitiation.CheckStart();
            }
            catch 
            {
                Application.Run(new ConfigurationError());
                error = true;
            }
            if (!error)
            {
                Application.Run(new MainMenuForm());
            }
            // Application.Run(new Form1());
        }
    }
}
