using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Word_Count
{
    public class StartUp
    {
        public static void Main()
        {
            string wordsFilePath = "words.txt";
            string textFilePath = "text.txt";

            Dictionary<string, int> wordsInfo = new Dictionary<string, int>();
            string[] words = File.ReadAllLines(wordsFilePath);
            string[] textLines = File.ReadAllLines(textFilePath);

            foreach (var word in words)
            {
                if (!wordsInfo.ContainsKey(word))
                {
                    wordsInfo.Add(word, 0);
                }
            }

            foreach (var line in textLines)
            {
                string[] currentWords = line
                    .Split(new char[] { ',', '.', '-', '!', '?', ':', ';', ' ', '\\' })
                    .Select(x => x.ToLower())
                    .ToArray();

                foreach (var item in currentWords)
                {
                    if (wordsInfo.ContainsKey(item.ToLower()))
                    {
                        wordsInfo[item]++;
                    }
                }
            }

            string actualResFilePath = "acutalResult.txt";
            string expectedResFilePath = "expectedReult.txt";

            foreach (var (key, value) in wordsInfo)
            {
                File.AppendAllText(actualResFilePath, $"{key}-{value}{Environment.NewLine}");
            }

            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText(expectedResFilePath, $"{key}-{value}{Environment.NewLine}");
            }
        }
    }
}
