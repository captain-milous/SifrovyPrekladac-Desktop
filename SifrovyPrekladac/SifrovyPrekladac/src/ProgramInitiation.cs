using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifrovyPrekladac.src
{
    public static class ProgramInitiation
    {
        public static void CheckStart()
        {
            CheckStructure();
        }

        private static void CheckStructure() 
        {
            if (!Directory.Exists("UserFiles"))
            {
                Directory.CreateDirectory("UserFiles");
            }
            if (!Directory.Exists("UserFiles\\historie"))
            {
                Directory.CreateDirectory("UserFiles\\historie");
            }
            if (!Directory.Exists("UserFiles\\sifry"))
            {
                Directory.CreateDirectory("UserFiles\\sifry");
            }
            if (!Directory.Exists("ProgramFiles"))
            {
                Directory.CreateDirectory("ProgramFiles");
            }
            if (!Directory.Exists("ProgramFiles\\logs"))
            {
                Directory.CreateDirectory("ProgramFiles\\logs");
            }
            if (!Directory.Exists("ProgramFiles\\sifry"))
            {
                Directory.CreateDirectory("ProgramFiles\\sifry");
            }
        }
    }
}
