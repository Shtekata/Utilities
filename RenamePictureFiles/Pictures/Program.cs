using System;
using System.IO;

namespace Pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            var folderPath = @"D:\OneDrive\Desktop\Site\Pictures";
            var name = 1;

            foreach (string fileName in Directory.EnumerateFiles(folderPath, "*.jpg"))
            {
                File.Copy(fileName, $"{folderPath}/{name}.jpg", true);
                File.Delete($"{fileName}");
                name++;
            }
        }
    }
}
