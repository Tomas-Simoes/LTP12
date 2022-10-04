using App2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App2.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View("Inicio");
        }

        public ViewResult Formulario()
        {
            return View("Formulario");
        }
    }
}