using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstSampleApp
{
    public class TraderContext : DbContext
    {
        public TraderContext() : base("name=TraderEntitiesCF")
        {

        }
        public DbSet<Person1> person1s { get; set; }
    }
}
