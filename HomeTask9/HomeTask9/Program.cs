using System;

namespace HomeTask9
{
    class Program
    {
        static void Main()
        {
            double[] Progression = new double[10];
            Console.WriteLine("Введите первый член арифметической прогрессии");
            var FirstMemberOfProgression = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите первый разность арифметической прогрессии");
            var DifferenceOfProgression = double.Parse(Console.ReadLine());
            for (int i = 0;i<10;i++)
            {
                Progression[i] = FirstMemberOfProgression + DifferenceOfProgression * i;
            }
            double[] OriginalProgression = Progression;
            Console.WriteLine(PrintArray(Progression));
            Console.WriteLine("Введите коэффициент увеличения элементов массива");
            var coefficient = double.Parse(Console.ReadLine());
            Console.WriteLine(PrintArray(IncreaseArray(Progression, coefficient)));
            Console.WriteLine(FindOfOddNumbers(Progression));
            Console.WriteLine("Введите коэффициент увеличения элементов массива");
            var degree = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintArray(PowArray(Progression, degree)));
        }
        static double PrintArray(double[] array)
        {
            int len = array.Length;
            for (int i = 0; i < len-1;i++)
            {
                Console.Write($"{array[i]}, ");
            }
            return array[len-1];
        }
        static double[] IncreaseArray(double[] array,double k)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                array[i] = array[i] + k;
            }
            return array;
        }
        static int FindOfOddNumbers(double[] array)
        {
            int len = array.Length;
            int k = 0;
            for (int i = 0; i < len; i++)
            {
                if (array[i] % 2 == 1)
                    k = k+1;
            }
            return k;
        }
        static double[] PowArray(double[] array, int degree)
        {
            int len = array.Length;
            for (int i = 0; i < len; i++)
            {
                array[i] = Math.Pow(array[i],degree);
            }
            return array;
        }
    }
}
