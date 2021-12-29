using System;

namespace ReHome_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Введите значение аргумента для функции варианта 16");
                var x = double.Parse(Console.ReadLine());
                Console.WriteLine(Function(x));
            }
        static string Function(double x)
        {
            if (x < -4)
                return $"f({x}) = 46";
            else if (x > 2)
                return $"f({x}) = 10";
            else
                return $"f({x}) = {3 * x * x - 2}";
        }
    }
}
