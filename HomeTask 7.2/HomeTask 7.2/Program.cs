using System;

namespace HomeTask_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество действительных чисел");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                double summ = 0;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Введите число");
                    summ = summ + double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Среднее арифметическое прогрессии равно {Math.Round(summ / n, 3)}");
            }
            else
                Console.WriteLine("Количество чисел не может быть равным нулю или отрицательным");
        }
    }
}
