using System;

namespace HomeTask3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значения аргумента для функции f(x)");
            var argument = double.Parse(Console.ReadLine());
            if ((argument == 0) || (argument < 1))
                Console.WriteLine("Значение аргумента не удовлетворяет области определения функции");
            else
                Console.WriteLine($"f({argument}) = {function1(argument)}");
            Console.ReadKey();
        }
        static double function1(double x)
        {
          return (Math.Sqrt(x + 1) + Math.Sqrt(x - 1))/Math.Sqrt(x);
            
        }
    }
}
