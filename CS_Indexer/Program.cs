using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexerExam obj = new IndexerExam();
            System.Console.WriteLine(obj[0] + " " + obj[1]);
            obj[0] = "Tran";
            obj[1] = "Hieu";
            System.Console.WriteLine(obj[0] + " " + obj[1]);
        }
    }
}
