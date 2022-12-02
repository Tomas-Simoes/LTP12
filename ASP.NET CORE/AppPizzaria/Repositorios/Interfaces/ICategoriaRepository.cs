using AppPizzaria.Context;
using AppPizzaria.Models;
using System.Collections;

namespace AppPizzaria.Repositorios.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria>categorias { get; }
    }
}
