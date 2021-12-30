using System;

namespace ZACHET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое и второе натуральное число через пробел");
            string number = Console.ReadLine();
            int pos = number.IndexOf(" ");
            int firstnumber = int.Parse(number.Substring(0,pos));
            int secondnumber = int.Parse(number.Substring(pos));
            Console.WriteLine($"Произведение чисел:{Multiplication(firstnumber, secondnumber)}");
            Console.WriteLine($"Частное чисел: {Division(firstnumber, secondnumber)}");
            Console.WriteLine($"Остаток от деления: {RemainOfDivision(firstnumber, secondnumber)}");
        }
        static int Multiplication(int a,int b)
        {
            int result = 0;
            for (int i = 1;i<=b;i++)
            {
                result = result + a;
            }
            return result;
        }
        static int Division(int a, int b)
        {
            int k = 0;
            while (a>=b)
            {
                a -= b;
                k++;
            }
            return k;
        }
        static int RemainOfDivision(int a, int b)
        {
            while (a >= b)
            {
                a -= b;
            }
            return a;
        }
        
        
    }
}
