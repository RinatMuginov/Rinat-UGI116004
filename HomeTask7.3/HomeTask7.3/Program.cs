using System;

namespace HomeTask7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите огранчиение E для задания 3 в варинте 16");
            double E = double.Parse(Console.ReadLine());
            if (E > 0)
            {
                double a = 1;
                for (int i = 1; ; i++)
                {
                    if (Math.Abs(2 - a) < E)
                    {
                        Console.WriteLine($"Для ограничения {E} подходит значение {a} под индексом {i}");
                        break;
                    }
                    else
                        a = a + Math.Pow(0.5, i);
                }
            }
            else
                Console.WriteLine("Значение ограничения должно быть положительным");
        }
    }
}
