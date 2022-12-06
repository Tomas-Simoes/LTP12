using TrabalhoPratico1.Models;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoPratico1.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }


    }
}
