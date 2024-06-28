using SifrovyPrekladac.src;
using SifrovyPrekladac.src.filesManager;
using SifrovyPrekladac.src.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SifrovyPrekladac
{
    public static class Program
    {
        private static Dictionary<char, string> MorseABC = new Dictionary<char, string>()
        {
            {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."}, {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
            {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"}, {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
            {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"}, {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"}, {'3', "...--"},
            {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."}, {'8', "---.."}, {'9', "----."}
        };
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DictionaryHandler.SaveToCsv(MorseABC, "mor-dir.csv");
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
