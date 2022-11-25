using AppPizzaria.Repositories.Interfaces;
using AppPizzaria.Models;
using Microsoft.EntityFrameworkCore;
using AppPizzaria.Context;

namespace AppPizzaria.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly AppDbContext _context;

        public PizzaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Pizza> Pizzas => _context.Pizzas.Include(c => c.Categorias);
        public IEnumerable<Pizza> PizzasPreferidas => _context.Pizzas.Where(l => l.IsPizzaPreferida).Include(c => c.Categorias);

        public Pizza GetPizzaById(int PizzaId)
        {
            return _context.Pizzas.FirstOrDefault(l => l.PizzaId == PizzaId);
        }
    }
}
