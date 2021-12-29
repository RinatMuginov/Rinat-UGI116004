using System;

namespace HomeTask_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] Progression = new double[10];
            Console.WriteLine("Введите первый член арифметической прогрессии");
            var FirstMemberOfProgression = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите первый разность арифметической прогрессии");
            var DifferenceOfProgression = double.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                Progression[i] = FirstMemberOfProgression + DifferenceOfProgression * i;
            }
            Console.WriteLine(PrintArray(Progression));
            Console.WriteLine("Введите коэффициент увеличения элементов массива");
            var coefficient = double.Parse(Console.ReadLine());
            Console.WriteLine(IncreaseArray(Progression, coefficient));
            Console.WriteLine($"Количество нечетных чисел в прогресии: {FindOfOddNumbers(Progression)}");
            Console.WriteLine("Введите степень, в которую следует возвести члены прогрессии");
            var degree = int.Parse(Console.ReadLine());
            Console.WriteLine(PowArray(Progression, degree));
        }
        static string PrintArray(double[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            return $"{array[len - 1]};";
        }
        static string IncreaseArray(double[] array, double k)
        {
            double k_memberOfProgression = 0;
            int len = array.Length;
            for (int i = 0; i < len - 1; i++)
            {
                k_memberOfProgression = array[i] + k;
                Console.Write($"{k_memberOfProgression}, ");
            }
            return $"{k_memberOfProgression + k};";
        }
        static int FindOfOddNumbers(double[] array)
        {
            int len = array.Length;
            int k = 0;
            for (int i = 0; i < len; i++)
            {
                if (array[i] % 2 == 1)
                    k = k + 1;
            }
            return k;
        }
        static string PowArray(double[] array, int degree)
        {
            int len = array.Length;
            int i = 0;
            for (i = 0; i < len - 1; i++)
            {
                Console.Write($"{Math.Pow(array[i], degree)}, ");
            }
            return $"{Math.Pow(array[len - 1], degree)};";
        }
    }
}

        