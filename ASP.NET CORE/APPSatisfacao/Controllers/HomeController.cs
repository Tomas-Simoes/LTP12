using APPSatisfacao.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace APPSatisfacao.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Inquerito()
        {
            return View("Inquerito");
        }

        [HttpPost]   
        public ViewResult Inquerito(RespostaInquerito resposta)
        {
            Repositorio.AdicionarInquerito(resposta);
            return View("Obrigado", resposta);
        }

        public ViewResult ListaInquerito()
        {
            return View("ListaInquerito", Repositorio.ListaInquerito.Where(c=>c.Satisfacao==true));
        }
    }
}