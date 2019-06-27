using System;
using System.IO;
using System.IO.Compression;


namespace Zip_And_Extract
{
    public class StartUp
    {
        public static void Main()
        {
            string sourcePath = "copyMe.png";
            string destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/zippedCopy.zip";

            // Creating ZIP Archive from directory:

            //ZipFile.CreateFromDirectory(sourcePath, destinationPath);

            // Creating ZIP from a file:

            using (var archive = ZipFile.Open(destinationPath, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(sourcePath, Path.GetFileName(sourcePath));
            }

        }
    }
}
