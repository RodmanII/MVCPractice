using MVCPractice.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCPractice.Data
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonContext")
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {            
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}