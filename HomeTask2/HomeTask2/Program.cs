using System;

namespace HomeTask2
{
    class Program
    {
        static void Main()
        {
            double volume, square;
            Console.WriteLine("Введите значение длины стороны основания правильной треугольной пирамиды");
            var side = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение высоты правильной треугольной пирамиды");
            var height = double.Parse(Console.ReadLine());
            volume = (height * Math.Sqrt(3) * side * side * 0.25) / 3;
            Console.WriteLine($"Объем правильной треугольной пирамиды равен {volume}");
            square = (0.5 * (side + side + side) * Math.Sqrt(height * height + ((side * side * 3) / 36))) + side * side * Math.Sqrt(3) * 0.25;
            Console.WriteLine($"Площадь поверхности правильной треугольной пирамиды равна {square}");
        }
    }
}
