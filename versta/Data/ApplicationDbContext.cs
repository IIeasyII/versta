using Microsoft.EntityFrameworkCore;
using versta.Models;

namespace versta.Data
{
    public class ApplicationDbContext : DbContext
    {
        /// <summary>
        /// Список заказов
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
