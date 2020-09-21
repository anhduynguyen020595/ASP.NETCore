using System;

namespace CS_OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector v1 = new MyVector(2, 3);
            MyVector v2 = new MyVector(3, 4);

            MyVector v3 = v1 + v2;
            v3.ShowXY();
        }
    }
}
