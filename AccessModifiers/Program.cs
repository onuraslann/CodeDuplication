using System;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Customer
    {
        private int Id { get; set; } // sadece tanımlandığı blokta geçerli
        protected string Name { get; set; }
        public void Save()
        {
           
            
        }
    }
    class Student:Customer
    {
        public void Save()
        {
       

        }
    }
    class Course //bir classın defaultu internaldır
    {
        public string Name { get; set; }
    }
}
