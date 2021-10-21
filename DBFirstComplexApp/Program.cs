using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
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
                Stopwatch watch = new Stopwatch();
                watch.Start();
                var Person1 = dbContext.Person1.Where(p => p.FirstName.Contains
                ("S")).ToList();
                Person1.ForEach(p =>
                {
                    var STUDENT = p.LastName.Where(s => s.Amount > 100).ToList();
                });
                Console.WriteLine(watch.Elapsed.TotalMilliseconds);

                watch.Restart();
                watch.Start();

                var pers = dbContext.Person1.Include("STUDENT").Where(p =>
                p.FirstName.Contains("S")).ToList();
                pers.ForEach(p =>
                             {
                                 var STUDENT = p.STUDENT.Where(s => s.Amount > 100).ToList
                                 ();
                             });
                Console.WriteLine(watch.Elapsed.TotalMilliseconds);
               
            }
            Console.ReadLine();
        }
    }
}
