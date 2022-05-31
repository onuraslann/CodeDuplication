using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList cities = new ArrayList();
            //cities.Add("Ankara");
            //cities.Add("Antalya");
            //cities.Add("Adana");
            //foreach (var i in cities)
            //{
            //    Console.WriteLine(i);
            //}
           
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Antalya");
            Console.WriteLine(cities.Contains("Ankara"));
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            List<Customer> customers = new List<Customer>();
             customers.Add(new Customer { Id=1, Name="Onur"});

            customers.Add(new Customer { Id = 2, Name = "Dogukan" });

           
            customers.AddRange(new Customer[2]
            {
                new Customer{ Id=3, Name="Alper"},
                new Customer{ Id=4, Name="Numan"}
            });

            var customer3 = new Customer { Id = 5, Name = "Mehmet" };
            customers.Insert(0, customer3);
            var count = customers.Count;
            customers.RemoveAll(x => x.Name == "Numan");
      
            foreach (var item in customers)
            {
                Console.WriteLine( item.Name);
            }
            Console.WriteLine(count);



            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Key", "Anahtar");
            dictionary.Add("Computer", "Bilgisayar");

            Console.WriteLine(dictionary["Key"]);
            Console.WriteLine(dictionary.ContainsKey("glass"));
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }




            Console.ReadLine();

       
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
