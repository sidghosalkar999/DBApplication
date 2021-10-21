using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CFWithExistingDB
{
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=TraderContext")
        {
        }

        public virtual DbSet<DEPT> DEPTs { get; set; }
        public virtual DbSet<Person1> Person1 { get; set; }
        public virtual DbSet<STUDENT> STUDENTs { get; set; }
        public virtual DbSet<HRM> HRMS { get; set; }
        public virtual DbSet<SalesPerson> SalesPersons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DEPT>()
                .Property(e => e.DEPTNAME)
                .IsUnicode(false);

            modelBuilder.Entity<Person1>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person1>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Person1>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.STDNAME)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.STDCLASS)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.STDRESULT)
                .IsUnicode(false);

            modelBuilder.Entity<STUDENT>()
                .Property(e => e.Amount)
                .HasPrecision(4, 2);

            modelBuilder.Entity<STUDENT>()
                .HasMany(e => e.DEPTs)
                .WithOptional(e => e.STUDENT)
                .HasForeignKey(e => e.SID);

            modelBuilder.Entity<STUDENT>()
                .HasMany(e => e.STUDENT1)
                .WithOptional(e => e.STUDENT2)
                .HasForeignKey(e => e.MNGRID);

            modelBuilder.Entity<HRM>()
                .Property(e => e.EMPNAME)
                .IsUnicode(false);

            modelBuilder.Entity<HRM>()
                .Property(e => e.EMPROLE)
                .IsUnicode(false);

            modelBuilder.Entity<HRM>()
                .Property(e => e.EMPADDR)
                .IsUnicode(false);

            modelBuilder.Entity<HRM>()
                .Property(e => e.EMAILID)
                .IsUnicode(false);
        }
    }
}
