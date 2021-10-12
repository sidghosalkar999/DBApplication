using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSampleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Entity Framework");

            using (masterEntities dbContext = new masterEntities())
            {
                dbContext.Person1.ToList().ForEach(emp => { Console.WriteLine($"FirstName: {emp.FirstName}"); });
            }

            Console.ReadLine();

        }
    }
}
