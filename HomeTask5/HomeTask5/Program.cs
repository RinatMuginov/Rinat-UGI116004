using System;

namespace HomeTask5
{
    class Program
    {
        static void Main()
        {
            string StringKosmos, StringSmeh;
            string FirstString = "микросхема";
            Console.WriteLine("Слова \"космос\" и \"смех\", полученные из слова \"микросхема\": ");
            StringKosmos = FirstString.Substring(2,1)+ FirstString.Substring(4, 2) + FirstString.Substring(0, 1) + FirstString.Substring(4, 2);
            Console.WriteLine(StringKosmos);
            StringSmeh = FirstString.Substring(5, 1) + FirstString.Substring(8, 1) + FirstString.Substring(7, 1) + FirstString.Substring(6, 1);
            Console.WriteLine(StringSmeh);

            Console.ReadKey();
        }
         
    }   
}
