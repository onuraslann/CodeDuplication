using System;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            OracleServer oracleServer = new OracleServer();
            sqlServer.Add();
            oracleServer.Add();
            Console.ReadLine();
        }
         
    }
    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Ekleme başarılı");
        }
    }
    class OracleServer : Database
    {

    }
}
