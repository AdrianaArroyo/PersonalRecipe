using Lab6_AdrianaAH_JonathanRM.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6_AdrianaAH_JonathanRM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
