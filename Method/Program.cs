using System;

namespace Method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           Add(20,30);
            Add(70);
            Add2();
        }
        public static void Add(int a ,int b=80)
        {
            var number = a + b;
            Console.WriteLine(number);
        }
        public static int Add2()
        {
           var a = Convert.ToInt32(Console.ReadLine());
            var b= Convert.ToInt32(Console.ReadLine());
            var number = a + b;
            return number;

        }
    }
}
