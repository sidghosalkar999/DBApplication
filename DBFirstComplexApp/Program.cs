using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstComplexApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (masterEntities dbContext = new masterEntities())
            {
                var Person1 = dbContext.Person1.First();
                Console.WriteLine($"Person Name:{Person1.FirstName}, STUDENT:{Person1.LastName}");
            }
            Console.ReadLine();
        }
    }
}
