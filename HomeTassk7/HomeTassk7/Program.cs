using System;

namespace HomeTassk7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите нижнее ограничение таблицы соответствия между фунтами и килограммами");
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double kg = i * 0.453;
                if (i % 10 == 1)
                    Console.WriteLine($"{i} фунт в килограммах равен {Math.Round(i * 0.453, 3)}");
                else if ((i % 10 == 2) || (i % 10 == 3) || (i % 10 == 4))
                    Console.WriteLine($"{i} фунта в килограммах равен {Math.Round(i * 0.453, 3)}");
                else
                    Console.WriteLine($"{i} фунтов в килограммах равен {Math.Round(i * 0.453, 3)}");

            }

        }
    }
}
