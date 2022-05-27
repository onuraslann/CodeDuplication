using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[] {"Onur","Dogukan","Ahmet" };
            foreach (string s in student)
            {
                Console.WriteLine(s);
            }
            int[] number = new int[] {1,2,3,5,6};
            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
            var city = "Ankara";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }
            var city2 = "Istanbul";
            var result = city + city2;
            Console.WriteLine(result);

            string names = "My name is  Onur Aslan";
            Console.WriteLine(names.Length);
            var result2 = names.EndsWith("a");
            Console.WriteLine(result2);
            var result3 = names.IndexOf("name");
            Console.WriteLine(result3);
            var result4 = names.LastIndexOf(" ");
            Console.WriteLine(result4);

            var result5 = names.Insert(0,"Aspnet");
            Console.WriteLine(result5);

            var result6 = names.Substring(3,4);
            Console.WriteLine(result6);

            var result7 = names.Replace(" ", "*");
            Console.WriteLine(result7);
        }
       
     
    }
}
