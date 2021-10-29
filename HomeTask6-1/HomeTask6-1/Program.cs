using System;

namespace HomeTask6._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите три целых числа, честность которых нужно сравнить");
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            if ((ParityCheck(a, b, c)) == true)
                Console.WriteLine("Числа одинаковой четности");
            else
                Console.WriteLine("Числа различной четности");

        }
        static bool ParityCheck(int k, int m, int n)
        {
            if ((k % 2 == m % 2) && (m % 2 == n % 2))
                return true;
            else
                return false;

        }
    }
}