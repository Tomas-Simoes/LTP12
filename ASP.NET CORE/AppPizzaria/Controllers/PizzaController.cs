using AppPizzaria.Repositorios.Interfaces;
using AppPizzaria.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AppPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _pizzaRepository;

        public PizzaController(IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public IActionResult List()
        {
            //ViewData["Titulo"] = "Todas as Pizzas";
            //ViewData["Data"] = DateTime.Now;
            //var pizzas = _pizzaRepository.Pizzas;
            //var totalpizzas = pizzas.Count();
            //ViewData["Total"] = totalpizzas;
            //return View(pizzas);

            var pizzaListViewModel = new PizzaListViewModel();
            pizzaListViewModel.Pizzas = _pizzaRepository.Pizzas;
            pizzaListViewModel.CategoriaAtual = "Categoria Atual";
              return View(pizzaListViewModel);
        }
    }
}
