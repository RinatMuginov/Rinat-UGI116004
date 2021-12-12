using System;

namespace HomeTask7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В каких разрядах вы хотите найти простые числа?");
            int NumberOfCategory = int.Parse(Console.ReadLine());
            int Category = 10;
            if (NumberOfCategory > 1)
                for (int i = 1; i <= NumberOfCategory - 1; i++)
                {
                    Category = Category * 10;
                }
            bool flag = false;
            for (int j = Category / 10; j <= Category; j++)
            {
                flag = false;
                for (int l = 2; l <= j / 2 + 1; l++)
                {
                    if (j % l == 0)
                        flag = true;
                }
                if (flag == false)
                    Console.WriteLine(j);
            }
        }
    }
}
