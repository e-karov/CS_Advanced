using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Directory_Traverse
{
    public  class StartUp
    {
        public static void Main()
        {
            string[] fileArray = Directory.GetFiles(".", "*.*");

            Dictionary<string, Dictionary<string, double>> dirInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo  directoryInfo = new DirectoryInfo(".");

            FileInfo[] allFiles = directoryInfo.GetFiles();

            foreach (FileInfo currentFile in allFiles)
            {
                double size = (currentFile.Length / 1024d);
                string fileName = currentFile.Name;
                string extension = currentFile.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }

                if (! dirInfo[extension].ContainsKey(fileName))
                {
                    dirInfo[extension].Add(fileName, size);
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";

            var sortedDictionary = dirInfo
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(s => s.Key, y => y.Value);

            foreach (var extension in sortedDictionary)
            {
                File.AppendAllText(path, extension.Key + Environment.NewLine);

                foreach (var (fileName, size) in extension.Value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path, $"--{fileName} - {Math.Round(size, 3)}kb" + Environment.NewLine);
                }
            }
        }
    }
}
