using System;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager { Id=1, Name="Onur"};
            Console.WriteLine(customerManager.Name);
            customerManager.Add();
            customerManager.Update();
        }
      
        }
    
}
