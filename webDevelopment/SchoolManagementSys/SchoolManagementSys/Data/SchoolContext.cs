using Microsoft.EntityFrameworkCore;
using SchoolManagementSys.Models;

namespace SchoolManagementSys.Data
{
    public class SchoolContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=SchoolManagementDb;Integrated Security=True");

        }
        public DbSet<Student>Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(P => P.Id).ValueGeneratedOnAdd();
        }
    }
}
