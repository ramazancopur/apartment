using Apartment.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Apartment.Dal.Concrete.EntityFramework.EFContext
{
    public class Context : DbContext
    {
        //Veri Tabanı oluşturmak için kullanılan sınıf
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CondooFee> CondooFees { get; set; }
        public DbSet<HostNote> HostNotes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<Hirer> Hirers { get; set; }
        public DbSet<Host> Hosts { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<User> Users { get; set; }

        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Code First to ignore PluralizingTableName convention
            // If you keep this convention then the generated tables will have pluralized names.
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        */

    }
}
