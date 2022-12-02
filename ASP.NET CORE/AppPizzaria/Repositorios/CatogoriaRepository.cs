using AppPizzaria.Context;
using AppPizzaria.Models;
using AppPizzaria.Repositorios.Interfaces;
using System.Collections;

namespace AppPizzaria.Repositorios.Interfaces
{
    public class CatogoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CatogoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> categorias => _context.Categorias;
    }
}
