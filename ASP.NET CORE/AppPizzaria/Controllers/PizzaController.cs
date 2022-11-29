using AppPizzaria.Repositories;
using AppPizzaria.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AppPizzaria.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRespository _pizzaRepository;

        public PizzaController(IPizzaRespository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        public IActionResult List()
        {
            ViewData["Titulo"] = "Todas as pizzas";
            ViewData["Data"] = DateTime.Now; 
            var pizzas = _pizzaRepository.Pizzas;
            var totalPizzas = pizzas.Count();
            ViewData["Total"] = totalPizzas;

            return View(pizzas);
        }
    }
}
