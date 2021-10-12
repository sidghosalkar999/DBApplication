using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TraderContext dbContext = new TraderContext())
            {
                var Person1 = dbContext.person1s.ToList();
            }

            Console.ReadLine();

        }
    }
}
