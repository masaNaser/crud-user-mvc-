using crud_user.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace crud_user.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Database=UserCrud(MVC);Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<User> Users { get; set; }
    }
}
