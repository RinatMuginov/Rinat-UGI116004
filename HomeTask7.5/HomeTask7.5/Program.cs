using System;

namespace HomeTask7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада");
            double deposit = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент для вклада");
            double percent = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine("Введите цель - получаемую сумму после пополнения счета'");
            double purpose = double.Parse(Console.ReadLine());
            for (int i = 1; ; i++)
            {
                deposit = deposit + percent * deposit;
                if (deposit > purpose)
                {
                    Console.WriteLine($"Месяц, на котором будет достигнута цель: {i}");
                    break;
                }
            }
        }
    }
}
