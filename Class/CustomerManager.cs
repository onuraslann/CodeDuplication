using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class CustomerManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi");
        }
        public void Update()
        {
            Console.WriteLine("Müşteriler güncellendi");
        }
    }
}
        

