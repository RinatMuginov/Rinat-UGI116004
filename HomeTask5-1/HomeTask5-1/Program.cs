using System;

namespace HomeTask5_1
{
    class Program
    {
        static void Main()
        {
            string NewStringOnLeet;
            Console.WriteLine("Введите строку на английском языке для перевода на язык \"Leet\"");
            var StringOnEnglish = Console.ReadLine();
            NewStringOnLeet = TranslateOnLeet(StringOnEnglish, "A", "4");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "a", "4");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "B", "8");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "b", "8");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "C", "(");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "c", "(");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "D", "|)");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "d", "|)");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "E", "3");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "e", "3");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "F", "|=");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "f", "|=");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "G", "6");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "g", "6");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "H", "|-|");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "h", "|-|");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "I", "!");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "i", "!");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "J", ")");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "j", ")");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "K", "|<");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "k", "|<");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "L", "1");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "l", "1");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "M", @"|\/|");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "m", @"|\/|");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "N", @"|\|");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "n", @"|\|");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "O", "0");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "o", "0");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "P", "|>");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "p", "|>");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "Q", "9");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "q", "9");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "R", "|2");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "r", "|2");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "S", "5");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "s", "5");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "T", "7");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "t", "7");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "U", "|_|");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "u", "|_|");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "V", @"\/");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "v", @"\/");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "W", @"\/\/");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "w", @"\/\/");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "X", "><");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "x", "><");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "Y", "'/");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "y", "'/");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "Z", "2");
            NewStringOnLeet = TranslateOnLeet(NewStringOnLeet, "z", "2");

            Console.WriteLine($"Строка \"{StringOnEnglish}\" на языка \"Leet\" будет переведена следующим образом:");
            Console.WriteLine(NewStringOnLeet);
            Console.ReadKey();
        }
        static string TranslateOnLeet(string stroka,string x, string y)
        {
            return stroka.Replace(x, y);        
        
        }
    }
}
