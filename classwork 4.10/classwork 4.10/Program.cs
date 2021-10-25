using System;

namespace hometask2
{
    class Program
    {
        static void Main(string[] args)
        {
            double V;
            Console.WriteLine("Введите значение длины стороны основания правильной треугольной пирамиды");
            var side = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение высоты правильной треугольной пирамиды");
            var high = double.Parse(Console.ReadLine());
            V = (high * Math.Sqrt(3) * side * side * 0.25) / 3;
            Console.WriteLine($"Объем правильной треугольной пирамиды равен {V}");

        }
    }
}
