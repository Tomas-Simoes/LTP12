using AppFicha9.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppFicha9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult todosClientes()
        {
            return View(Dados.todosClientes());
        }

        [HttpGet]
        public IActionResult adicionarCliente()
        {
            return View();
        }

        [HttpPost]
        public IActionResult adicionarCliente(Cliente c)
        {
            Dados.adicionarNovoCliente(c);
            return RedirectToAction("adicionarCliente");
        }

        [HttpGet]
        public IActionResult editarCliente(int id)
        {
            return View(Dados.dados_cliente(id));
        }
        [HttpPost]
        public IActionResult editarCliente(Cliente c)
        {
            Dados.editarCliente(c);
            return RedirectToAction("todosClientes");
        }

        [HttpGet]
        public IActionResult eliminarCliente(int id)
        {
            Dados.eliminarCliente(id);
            return RedirectToAction("todosClientes");
        }
    }
}