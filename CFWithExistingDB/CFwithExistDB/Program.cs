using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFwithExistDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using(DataModel dbContext = new DataModel())
            {
                var stu = dbContext.STUDENTs.ToList();
            }
        }
    }
}
