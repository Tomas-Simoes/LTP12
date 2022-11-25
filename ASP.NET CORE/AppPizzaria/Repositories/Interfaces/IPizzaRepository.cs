using AppPizzaria.Context;
using AppPizzaria.Models;

namespace AppPizzaria.Repositories.Interfaces
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> Pizzas { get; }
        IEnumerable<Pizza> PizzasPreferidas { get; }
        Pizza GetPizzaById(int PizzaId);

    }
}
