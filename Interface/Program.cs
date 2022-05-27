using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonManager personManager = new PersonManager();
            //personManager.Add(new Customer
            //{
            //    Id = 1,
            //    Name = "Onur",
            //    Address = "İstanbul"
            //});



            //personManager.Add(new Student
            //{
            //    Id = 1,
            //    Name = "Dogukan",
            //    Departman = "Bilgisayar Mühendisi"
            //});
            //Console.ReadLine();

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlCustomerDal());
            //Console.ReadLine();

            ICustomerDal[] customerDal = new ICustomerDal[2]
            {
             new SqlCustomerDal(),
            new OracleCustomerDal()
            };
            foreach (var item in customerDal)
            {
                item.Add();
            }
        }
        interface IPerson
        {
             int Id { get; set; }
            string Name { get; set; }
        }
        class Customer : IPerson
        {
            public int Id {get; set; }
            public string Name {get; set; }
            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Departman { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine("Eklenen kişi : " +person.Name);
            }
        }
    }
}
