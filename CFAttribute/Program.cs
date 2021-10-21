using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            using (AttributeContext dbContext = new AttributeContext())
            {
                var Student = dbContext.Students.ToList();
            }

            Console.ReadLine();
        }
    }
}
