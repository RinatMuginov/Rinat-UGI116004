using System;

namespace HomeTask7
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значение аргумента для функции варианта 16");
            var x = double.Parse(Console.ReadLine());
            if (x < -4)
                Console.WriteLine($"f({x}) = 46");
            else if (x > 2)
                Console.WriteLine($"f({x}) = 10");
            else
                Console.WriteLine($"f({x}) = {3*x*x - 2}");

        }
    }
}
