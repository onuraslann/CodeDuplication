using System;
using System.Linq;

namespace Method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           Add(20,30);
            Add(70);
            //Add2();
            var number1 = 20;
            var number2 = 30;
            var result = Add3(ref number1, number2);
            Console.WriteLine(result);
            var result1 = Multiply(20, 30);
            Console.WriteLine(result1);
            Console.WriteLine(Multiply(20, 30, 40));
            Console.WriteLine(Add4(20, 30, 40, 56));

        }
        static int Add3(ref int a,int b)
        {
            a = 50;
            var number = a + b;
            return number;
        }
        public static void Add(int a ,int b=80)
        {
            var number = a + b;
            Console.WriteLine(number);
        }
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2 * number3;
        }   
        //public static int Add2()
        //{
        //   var a = Convert.ToInt32(Console.ReadLine());
        //    var b= Convert.ToInt32(Console.ReadLine());
        //    var number = a + b;
        //    return number;

        //}
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
