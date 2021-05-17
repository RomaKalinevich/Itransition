using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace WebApplication1.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext() 
        { }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
    : base(options)
        {
            Database.EnsureCreated();
        }
        //public DbSet<Company> Company { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Comments> Comments { get; set; }
        //public DbSet<Likes> Likes { get; set; }
        //public DbSet<Rating> Rating { get; set; }
    }
}
