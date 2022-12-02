using AppPizzaria.Models;
using System.Collections;

namespace AppPizzaria.ViewModels
{
    public class PizzaListViewModel
    {
        public IEnumerable<Pizza> Pizzas { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
