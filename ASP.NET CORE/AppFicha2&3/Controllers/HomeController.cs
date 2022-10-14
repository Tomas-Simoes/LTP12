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

        public ViewResult Inscritos()
        {
            return View("ListaFinal", Repositorio.ListaFinal.Where(c=>c.Inscrever==true));
        }

        [HttpGet]
        public ViewResult Formulario()
        {
            return View("Formulario");
        }

        [HttpPost] 
        public ViewResult Formulario(RespostaInscricao resposta)
        {
            // adicionar a lista
            Repositorio.AdicionarResposta(resposta);
            return View("Obrigado", resposta);
        }
    }
}