using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFAttribute
{
    public class AttributeContext : DbContext
    {
        public AttributeContext() : base("Name=AttributeCN")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<AttributeContext>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Property Attributes
            modelBuilder.Entity<Student>().HasKey(s => s.Id);
            modelBuilder.Entity<Student>().Property(s => s.BirthDate).IsRequired();
            modelBuilder.Entity<Student>().Property(s => s.FirstName).HasColumnName("siddhesh");
            modelBuilder.Entity<Student>().Property(s => s.LastName).HasMaxLength(10);

            //Table Entity Attributes
            modelBuilder.Entity<Person>().ToTable("PersonAddress");
            modelBuilder.Entity<Student>().HasIndex(s => s.Id).IsUnique(true);
            modelBuilder.Entity<Student>().Ignore(s => s.Age);

            /*Relationships
            modelBuilder.Entity<Student>()
                .HasOptional(s => s.FirstName)
                .WithRequired(a => a.);*/
            
            base.OnModelCreating(modelBuilder);

        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
    }
}
