using System;

namespace HomeTask6_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координаты для того, чтобы проверить принадлежит ли точка области варианта 16");
            var CoordinateX = double.Parse(Console.ReadLine());
            var CoordinateY = double.Parse(Console.ReadLine());
            if ((XandYonGraphic(CoordinateX, CoordinateY)) == true)
                Console.WriteLine($"Точка ({CoordinateX};{CoordinateY}) принадлежит заданной области");
            else
                Console.WriteLine($"Точка ({CoordinateX};{CoordinateY}) не принадлежит заданной области");

        }
        static bool XandYonGraphic (double x,double y)
        {
            if ((x <= 1.5) && (x >= -1) && (y <= 2) && (y >= -0.5))
                return true;
            else
                return false;
        }
    }
}
