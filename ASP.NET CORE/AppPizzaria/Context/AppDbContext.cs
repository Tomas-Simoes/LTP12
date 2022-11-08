using AppPizzaria.Models;
using Microsoft.EntityFrameworkCore;
namespace AppPizzaria.Context
{
    public class AppDbContext : DbContext
    {   
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }   
    }
}
