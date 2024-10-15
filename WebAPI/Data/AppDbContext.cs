
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CompanyRevenue> CompanyRevenues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyRevenue>().ToTable("CompanyRevenue"); // 確保這裡的名稱正確
        }
    }
}
