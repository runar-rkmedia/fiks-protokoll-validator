using KS.GIArkivValidator.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace KS.GIArkivValidator.WebAPI.Data
{
    public class FiksIOMessageDBContext : DbContext
    {
        public FiksIOMessageDBContext(DbContextOptions<FiksIOMessageDBContext> options)
            : base(options)
        {
        }

        public DbSet<TestCase> TestCases { get; set; }
        public DbSet<TestSession> TestSessions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.\\SQLEXPRESS; Initial Catalog = gi-arkiv-2.0-validator; Integrated Security = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestCase>().HasIndex(t => t.TestName).IsUnique();
        }
    }
}