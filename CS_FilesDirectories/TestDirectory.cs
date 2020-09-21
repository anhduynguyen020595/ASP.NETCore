using System;
using System.IO;
namespace CS_FilesDirectories
{
    public class TestDirectory
    {
        public static void ListFileDirectory(string path)
        {
            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                System.Console.WriteLine(file);
            }

            foreach (var directory in directories)
            {
                System.Console.WriteLine(directory);
                ListFileDirectory(directory);
            }
        }
    }
}