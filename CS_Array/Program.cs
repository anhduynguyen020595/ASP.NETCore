using System;

namespace CS_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Predicate<int> predicate = (int number) => {return number%2 == 0; };

            int[] oddNumbers = Array.FindAll(numbers, predicate);

            Action<int> printNumber = (int number)=> System.Console.WriteLine(number);
            Array.ForEach(oddNumbers, printNumber);

        }
    }
}
