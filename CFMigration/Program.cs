using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFMigration
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context dbContext = new Context())
            {
                var Student = dbContext.Students.ToList();
            }

            Console.ReadLine();
        }
    }
}
