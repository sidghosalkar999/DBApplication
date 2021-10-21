using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFMigration
{
    public class Context : DbContext
    {
        public Context() : base("name=MigrationDemoDBCN")
        {
           

        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Version> Versions { get; set; }
    }
}
