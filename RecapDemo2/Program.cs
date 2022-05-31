using System;

namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.logger = new FileLogger();
            customerManager.Add();
        }
    }
    class CustomerManager
    {
        public ILogger logger  { get; set; }
        public void Add()
        {
            logger.Log();

            Console.WriteLine("Customer Added");
        }
    }
    class Logger: ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged! ");
        }
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("FileLogger!");
        }
    }
    interface ILogger
    {
        void Log();
    }
}
