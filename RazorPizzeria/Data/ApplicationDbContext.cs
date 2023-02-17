using Microsoft.EntityFrameworkCore;
using RazorPizzeria.Models;
using System.Transactions;

namespace RazorPizzeria.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
