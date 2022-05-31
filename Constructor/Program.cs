using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();
            customerManager.Add();
            customerManager.List();
            Manager.DoSomething();
            Product product2 = new Product(1,"Computer");
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count;

        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed! {0} items ",_count);

        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }
    class Product
    {
        private int _id { get; set; }
        private string _name { get; set; }
        public Product(int id, string name)
        {
            _id = id;
            _name= name;
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
       
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Database");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }
    class EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Employee Added ! ");
        }

    }
   static class Manager
    {
        public static  void DoSomething()
        {
            Console.WriteLine("Done");
        }
    }

}
