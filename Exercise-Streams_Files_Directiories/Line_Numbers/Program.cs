using System;
using System.IO;
using System.Linq;


namespace Line_Numbers
{
    public class StartUp
    {
        public  static void Main()
        {
            string filePath = "text.txt";
            string[] lines = File.ReadAllLines(filePath);

            int lineCounter = 1;

            foreach (var line in  lines)
            {
                int lettersCount = line.Count(Char.IsLetter);
                int punctuationMarksCount = line.Count(Char.IsPunctuation);

                File.AppendAllText("output.txt", $"{lineCounter}: {line} ({lettersCount})({punctuationMarksCount})" +
                    $"{Environment.NewLine}");

                lineCounter++;
            }
        }
    }
}
