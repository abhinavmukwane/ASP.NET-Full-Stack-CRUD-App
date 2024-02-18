using ASP.NET_Fullstack_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Fullstack_API.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
