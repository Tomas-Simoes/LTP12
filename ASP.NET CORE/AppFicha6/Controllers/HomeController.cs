using AppFicha6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppFicha6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("View");
        }
    }
}