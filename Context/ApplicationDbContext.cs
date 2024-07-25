using Microsoft.EntityFrameworkCore;
using BankPractice.Models;

namespace BankPractice.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Bank> BankDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bank>().HasKey(b => b.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
