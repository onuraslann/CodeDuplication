using System;

namespace ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            number2 = number1;
            number1 = 30;
            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Diyarbakır", "Adana" };
            string[] cities2 = new string[] { "Bursa,Bolu,Balıkesir" }; 
            cities2 = cities1;
            cities1[0] = "Malatya";
            cities1[1] = "Denizli";
            cities2[0] = "Antalya";

            Console.WriteLine(cities2[0]);
             
        }
    }
}
