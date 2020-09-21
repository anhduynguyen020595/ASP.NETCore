using System;
using System.IO;

namespace CS_FilesDirectories
{
    public class TestFile
    {
        public static void TestWriteAllText()
        {
            var fileName = "test.txt";
            string contentFile = "Hello World!";

            // Get Document folder of User in systems
            // var directoryMyDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var directoryMyDoc = Directory.GetCurrentDirectory();

            var fullPath = Path.Combine(directoryMyDoc, fileName);

            File.WriteAllText(fullPath, contentFile);

            System.Console.WriteLine($"File is saved at {directoryMyDoc}{Path.DirectorySeparatorChar}{fileName}");
        }

        public static void TestAppendAllText(){
            var fileName = "test.txt";
            string contentFile = "Add text";

            var directoryMyDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var fullPath = Path.Combine(directoryMyDoc, fileName);

            if(File.Exists(fullPath)){
                File.AppendAllText(fullPath, contentFile);
            }
            else{
                File.WriteAllText(fullPath, contentFile);
            }

            System.Console.WriteLine(fullPath);

            string s = File.ReadAllText(fullPath);

            System.Console.WriteLine(s);
        }
    }
}