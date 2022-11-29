using AppPizzaria.Context;
using AppPizzaria.Models;
using AppPizzaria.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AppPizzaria.Repositories
{
    public class PizzaRepository : IPizzaRespository
    {
        private readonly AppDbContext _context;

        public PizzaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Pizza> Pizzas => _context.Pizzas.Include(c=>c.Categorias);
        public IEnumerable<Pizza> PizzasPreferidas => _context.Pizzas.Where(l => l.IsPizzaPreferida).Include(c => c.Categorias);
        public Pizza GetPizzaById(int PizzaId)
        {
            return _context.Pizzas.FirstOrDefault(l => l.PizzaId == PizzaId);
        }
    }
}
