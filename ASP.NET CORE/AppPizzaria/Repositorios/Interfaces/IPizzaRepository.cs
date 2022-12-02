using AppPizzaria.Models;
using System.Collections;

namespace AppPizzaria.Repositorios.Interfaces
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> Pizzas { get; }
        IEnumerable<Pizza> PizzasPreferidas { get; }
        Pizza GetPizzaById(int PizzaId);

    }
}
