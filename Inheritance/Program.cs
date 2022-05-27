using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Customer customer = new Customer();
            customer.Name = "Onur";
            Console.WriteLine(customer.Name);
            Student student = new Student();
            student.Departman = "Bilgisayar Mühendisi";
            Console.WriteLine(student.Departman);
        }
       
        
    }
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

    }
    class Customer : Person
    {

    }
    class Student : Person
    {
        public string Departman { get; set; }

    }
}
