using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Net.General.ManageFiles
{
    public class ExampleFile
    {
        private readonly string path = @"c:\ejemplo\fichero.txt";

        public void ReadStreamReaderFile()
        {
            //Accedemos al fichero
            using (StreamReader reader = new StreamReader(path))
            {
                string text; //Creamos la variable que contendrá el texto
                while ((text = reader.ReadLine()) != null) //Leemos línea por línea
                {
                    Console.WriteLine(text); //Mostramos la información
                }
            }
        }

        public void WriteStreamReaderFile()
        {
            string[] countries = new string[] { "USA", "Inglaterra", "Alemaia" };
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string item in countries)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public void ReadFile()
        {
            string filereader = File.ReadAllText(path);
        }

        public void WriteFile()
        {
            string[] paises = new string[] { "USA", "England", "Germany" };

            File.WriteAllText(path, "China Japon Korea");
            File.WriteAllLines(path, paises);
        }

        public void ReadFileToModifyContent()
        {
            int lenghtYear = 4;
            int counter = 0;
            string formatDate = string.Empty;

            foreach (string line in File.ReadLines(@"ruta_example_script.sql"))
            {
                if (line.Contains("("))
                {
                    string[] split = line.Split("(");
                    string[] splitDate = split[0].Split(",");
                    string[] valueToCheck = splitDate[0].Replace("\'", "").Split("-");

                    if (valueToCheck[0].Length == lenghtYear)
                    {
                        formatDate = $"";
                        Debug.WriteLine($"my query {formatDate}");
                    }
                    else
                    {
                        Debug.WriteLine(string.Concat(line));
                    }
                }
                else
                {
                    Debug.WriteLine(string.Concat(line));
                }

                counter++;
            }

            Debug.WriteLine($"Total lines readed{ counter}");
        }
    }
}
