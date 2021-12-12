using System;

namespace HomeTask7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, для которого нужно найти количество значащих нулей в двоичной записи");
            var n = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 1; ; i++)
            {
                if (n % 2 == 0)
                    k++;
                n = n / 2;
                if (n == 0)
                    break;
            }
            Console.WriteLine($"Нулей в двоичной записей числа: {k}");
        }
    }
}
