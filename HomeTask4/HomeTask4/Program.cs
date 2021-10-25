using System;

namespace HomeTask4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Значение x для варианта 16 равно {Method16(2,3) + Method16(3,7) + Method16(5,5)}");
        }
        static double Method16(double x, double y)
        {
            return Math.Sqrt(x + Math.Log(1 + Math.Sqrt(y)));
        }
    }
}
