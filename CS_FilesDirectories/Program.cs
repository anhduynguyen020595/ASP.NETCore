using System;
using System.IO;
namespace CS_FilesDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            //     GetDriveInformation.GetDrivesInfor();

            //     TestFile.TestWriteAllText();

            //     TestFile.TestAppendAllText();

            TestDirectory.ListFileDirectory(Directory.GetCurrentDirectory());
        }
    }
}
