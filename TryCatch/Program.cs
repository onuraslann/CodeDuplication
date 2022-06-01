using System;
using System.Collections.Generic;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                List<string> students = new List<string> { "Onur", "Dogukan", "Mehmet" };

                if (!students.Contains("Ahmet"))
                {
                    throw new RecordNotFoundException ( "Record Not Found");

                }
                else
                {
                    Console.WriteLine("Record Found");
                }

            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
              
            }




    }
    
    }

}
