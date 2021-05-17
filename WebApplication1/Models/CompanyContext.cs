using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {
        }
        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=userandcompanydb;Trusted_Connection=True;");
            }
        }
        public DbSet<Company> Company { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Likes> Likes { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Reward> Reward { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Company>().HasKey(x => x.Id);

            base.OnModelCreating(builder);
        }
    }

}
