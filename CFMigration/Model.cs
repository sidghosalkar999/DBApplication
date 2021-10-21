using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFMigration
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual Person Person { get; set; }
    }
    public class Person
    {
        public int PersonId { get; set; }
        public string City { get; set; }
        public int state { get; set; }

        public virtual Student Student { get; set; }
    }
    public class Version
    {
        public int Id { get; set; }
    }
}
