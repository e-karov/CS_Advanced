using System;
using System.IO;
using System.Linq;

namespace _01.Even_Lines
{
    public class StartUp
    {
        public static void Main()
        {
            string filePath = "text.txt";
            string outputFilePath = "output.txt";

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    int counter = 0;

                    string line = String.Empty;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (counter % 2 == 0)
                        {
                            string replaced = ReplaceSymbols(line);
                            writer.WriteLine(String.Join(" ", replaced.Split().Reverse()));
                        }

                        counter++;
                    }
                }
            }
        }

        private static string ReplaceSymbols(string text)
        { 
            // {"-", ",", ".", "!", "?"}

            return text.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }
    }
}
