using AppPizzaria.Models;

namespace AppPizzaria.Repositories.Interfaces
{
    public interface IPizzaRespository
    {
        IEnumerable<Pizza> Pizzas { get; }
        IEnumerable<Pizza> PizzasPreferidas { get; }
        Pizza GetPizzaById(int PizzaId);
    }
}
