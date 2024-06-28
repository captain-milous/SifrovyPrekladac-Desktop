using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SifrovyPrekladac.src.filesManager
{
    public static class DictionaryHandler
    {
        public static void SaveToCsv(Dictionary<char, string> dictionary, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var kvp in dictionary)
                {
                    writer.WriteLine($"{kvp.Key};{kvp.Value}");
                }
            }
        }

        public static Dictionary<char, string> LoadFromCsv(string filePath)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');
                    char key = ' ';
                    string value = parts[1];
                    if (parts[0].Length == 1) 
                    {
                        key = parts[0].ElementAt(0);
                        dictionary.Add(key, value);
                    }
                    else
                    {
                        throw new Exception("");
                    }
                }
            }

            return dictionary;
        }
    }
}
