using System;
using System.IO;
using System.Linq;


namespace Copy_Binary_File
{
    public class StartUp
    {
        public static void Main()
        {
            string filePath = "copyMe.png";
            string copyPath = "copy.png";

            using (FileStream reader = new FileStream(filePath, FileMode.Open))
            {
                using (FileStream writer = new FileStream(copyPath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[4096];

                        int size = reader.Read(byteArray, 0, byteArray.Length);

                        if (size == 0)
                        {
                            break;
                        }

                        writer.Write(byteArray, 0, byteArray.Length);
                    }
                }
            }
            
        }
    }
}
