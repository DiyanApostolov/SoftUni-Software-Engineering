using System;
using System.IO;

namespace _6.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("../../../TestFolder");
            double sum = 0;

            foreach (var filePath in files)
            {
                FileInfo file = new FileInfo(filePath);
                sum += file.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("../../../Output.txt", sum.ToString());
        }
    }
}
