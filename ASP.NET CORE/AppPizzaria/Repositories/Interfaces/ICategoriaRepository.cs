using AppPizzaria.Models;

namespace AppPizzaria.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        //propriedade de leitura que devolve uma colecao
        //de objetos do tipo Categoria

        IEnumerable<Categoria> Categorias { get; }
    }
}
