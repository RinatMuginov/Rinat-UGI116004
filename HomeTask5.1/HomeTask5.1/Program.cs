using System;

namespace HomeTask5._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку на английском языке для перевода на язык \"Leet\"");
            var StringOnEnglish = Console.ReadLine();

            Console.WriteLine($"Строка \"{StringOnEnglish}\" на языка \"Leet\" будет переведена следующим образом:");
            Console.WriteLine(TranslateOnLeet(StringOnEnglish));
            Console.ReadKey();
        }
        static string TranslateOnLeet(string stroka)
        {
            stroka = stroka.Replace("A", "4");
            stroka = stroka.Replace("a", "4");
            stroka = stroka.Replace("B", "8");
            stroka = stroka.Replace("b", "8");
            stroka = stroka.Replace("C", "(");
            stroka = stroka.Replace("c", "(");
            stroka = stroka.Replace("D", "|)");
            stroka = stroka.Replace("d", "|)");
            stroka = stroka.Replace("E", "3");
            stroka = stroka.Replace("e", "3");
            stroka = stroka.Replace("F", "|=");
            stroka = stroka.Replace("f", "|=");
            stroka = stroka.Replace("G", "6");
            stroka = stroka.Replace("g", "6");
            stroka = stroka.Replace("H", "|-|");
            stroka = stroka.Replace("h", "|-|");
            stroka = stroka.Replace("I", "!");
            stroka = stroka.Replace("i", "!");
            stroka = stroka.Replace("J", ")");
            stroka = stroka.Replace("j", ")");
            stroka = stroka.Replace("K", "|<");
            stroka = stroka.Replace("k", "|<");
            stroka = stroka.Replace("L", "1");
            stroka = stroka.Replace("l", "1");
            stroka = stroka.Replace("M", @"|\/|");
            stroka = stroka.Replace("m", @"|\/|");
            stroka = stroka.Replace("N", @"|\|");
            stroka = stroka.Replace("n", @"|\|");
            stroka = stroka.Replace("O", "0");
            stroka = stroka.Replace("o", "0");
            stroka = stroka.Replace("P", "|>");
            stroka = stroka.Replace("p", "|>");
            stroka = stroka.Replace("Q", "9");
            stroka = stroka.Replace("q", "9");
            stroka = stroka.Replace("R", "|2");
            stroka = stroka.Replace("r", "|2");
            stroka = stroka.Replace("S", "5");
            stroka = stroka.Replace("s", "5");
            stroka = stroka.Replace("T", "7");
            stroka = stroka.Replace("t", "7");
            stroka = stroka.Replace("U", "|_|");
            stroka = stroka.Replace("u", "|_|");
            stroka = stroka.Replace("V", @"\/");
            stroka = stroka.Replace("v", @"\/");
            stroka = stroka.Replace("W", @"\/\/");
            stroka = stroka.Replace("w", @"\/\/");
            stroka = stroka.Replace("X", "><");
            stroka = stroka.Replace("x", "><");
            stroka = stroka.Replace("Y", "'/");
            stroka = stroka.Replace("y", "'/");
            stroka = stroka.Replace("Z", "2");
            stroka = stroka.Replace("z", "2");
            return stroka;
        }
    }
    
}
