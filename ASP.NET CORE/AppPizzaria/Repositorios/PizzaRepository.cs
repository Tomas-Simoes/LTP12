using AppPizzaria.Context;
using AppPizzaria.Models;
using AppPizzaria.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.IO.Pipes;

namespace AppPizzaria.Repositorios
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly AppDbContext _context;

        public PizzaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Pizza> Pizzas => _context.Pizzas.Include(c=>c.Categorias);

        public IEnumerable<Pizza> PizzasPreferidas => _context.Pizzas.Where(l => l.IsPizzaPreferida).Include(c => c.Categorias);

        public Pizza GetPizzaById(int PizzaId)
        {
            return _context.Pizzas.FirstOrDefault(l => l.PizzaId == PizzaId);
        }
    }
}
