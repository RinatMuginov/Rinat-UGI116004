using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork13
{
    class Program
    {
        static void Main()
        {
            //Нахождение количества стопок с ящиками
            string path = "boxes.txt";
            int max = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] != ' ')
                            if (Convert.ToInt32(line[i]) > max)
                                max = Convert.ToInt32(line[i]);
                    }
                }
            }
            max = Convert.ToInt32(Convert.ToString((Convert.ToChar(max))));

            //Заполнение листа построчно без пробелов для более удобного переноса в стеки и вывод изначального расположения
            List<string> numbers = new List<string>();
            Console.WriteLine("Изначальное расположение:");
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numbers.Add(line);
                }
            }
            for (int i = 0;i<max;i++)
            {
                Console.WriteLine($"Стопка {i + 1}: {numbers[i]}");
                numbers[i] = numbers[i].Replace(" ", "");
            }

            //формирование единого стека и перенос всех ящиков в первую стопку
            string s1 = "Переложить ящик ";
            string s2 = " из стопки ";
            string s3 = " в стопку ";
            Stack<string> notes = new Stack<string>();
            string line1 = numbers[0];
            for (int l = 0; l < line1.Length; l++)
            {
                notes.Push(Convert.ToString(line1[l]));
            }
            int j,k=0;
            numbers.RemoveAt(0);
            for (int i = 0; i < max-1; i++)
            {
                string line = numbers[i]; 
                for (int l = line.Length - 1;l >= 0;l--)
                {
                    notes.Push(Convert.ToString(line[l]));
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        j = i + 2;
                        writer.WriteLine(s1+ line[l] + s2 + j +s3+"1");
                    }
                    k++;
                }
            }

            //симуляция переносов ящиков в стопки для записей
            Stack<string> notes1 = new Stack<string>();
            var boxes = new Dictionary<string, int>();
            for (int i = 1; i <= max; i++)
                boxes.Add(Convert.ToString(i), 0);
            string box;
            while(notes.Count > 0)
            {
                box = notes.Pop();
                if ((box == "1") || (box == "2"))
                {
                    notes1.Push(box);
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine(s1 + box + s2 + "1" + s3 + "2");
                    }
                    k++;
                }
                else
                {
                    boxes[box] += 1;
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine(s1 + box + s2 + "1" + s3 + box);
                    }
                    k++;
                }
            }
            while (notes1.Count > 0)
            {
                box = notes1.Pop();
                if (box == "1")
                {
                    boxes["1"] += 1;
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine(s1 + box + s2 + "2" + s3 + "1");
                    }
                    k++;
                }
                else
                {
                    notes.Push(box);
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine(s1 + box + s2 + "2" + s3 + "3");
                    }
                    k++;
                }
            }
            while (notes.Count > 0)
            {
                box = notes.Pop();
                if (box == "2")
                {
                    boxes["2"] += 1;
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine(s1 + box + s2 + "3" + s3 + "2");
                    }
                    k++;
                }
            }

            //Вывод конечного результата
            Console.WriteLine("\nЧисло переносов: " + k);
            Console.WriteLine("\nКонечное расположение:");
            foreach (var number in boxes)
            {
                Console.WriteLine($"Стопка {number.Key}: {String.Concat(Enumerable.Repeat(number.Key + " ", number.Value))}");
            }
        }
        

        
    }
}
