using System;
using System.IO;
using System.Text;

namespace CS_Stream_FileStream
{
    public class TestFileStream
    {
        public static void WriteFile()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");

            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {

                //Write BOM - UTF8
                Encoding encoding = Encoding.UTF8;
                byte[] bom = encoding.GetPreamble();
                stream.Write(bom, 0, bom.Length);

                string s1 = "HelloWorld";
                string s2 = "Test File Stream";

                byte[] buffer = encoding.GetBytes(s1);
                stream.Write(buffer, 0, buffer.Length);

                buffer = encoding.GetBytes(s2);
                stream.Write(buffer, 0, buffer.Length);
            }
        }

        public static void ReadFile()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "test.txt");

            int SIZEBUFFER = 256;

            using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                // Encoding encoding = UtilsEncoding.GetEncoding(stream);

                Encoding encoding = Encoding.UTF8;

                // System.Console.WriteLine(encoding.ToString());

                byte[] buffer = new byte[SIZEBUFFER];

                bool endRead = false;

                do
                {
                    int numberRead = stream.Read(buffer, 0, SIZEBUFFER);
                    if (numberRead == 0) endRead = true;
                    if (numberRead < SIZEBUFFER)
                    {
                        Array.Clear(buffer, numberRead, SIZEBUFFER - numberRead);
                    }

                    string s = encoding.GetString(buffer, 0, numberRead);
                    System.Console.WriteLine(s);
                } while (!endRead);
            }
        }
        
        public static void CopyFile()
        {
            string filepath_src = "/mycode/1.txt";
            string filepath_des = "/mycode/3.txt";

            int SIZEBUFFER = 5;
            using (var streamwrite = File.OpenWrite(filepath_des))
            using (var streamread = File.OpenRead(filepath_src))
            {
                byte[] buffer = new byte[SIZEBUFFER];
                bool endread = false;
                do
                {
                    int numberRead = streamread.Read(buffer, 0, SIZEBUFFER);
                    if (numberRead == 0) endread = true;
                    else
                    {
                        streamwrite.Write(buffer, 0, numberRead);
                    }

                } while (!endread);

            }
        }
    }
}