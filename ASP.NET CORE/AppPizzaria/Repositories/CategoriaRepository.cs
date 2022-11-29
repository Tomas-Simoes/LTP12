using AppPizzaria.Context;
using AppPizzaria.Models;
using AppPizzaria.Repositories.Interfaces;

namespace AppPizzaria.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        //para aceder as categorias e preciso acedar a BD
        //entao e preciso criar uma instancia do contexto definido no EF
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
