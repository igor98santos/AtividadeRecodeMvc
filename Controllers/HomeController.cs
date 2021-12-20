using Entrega.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Entrega.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Promoções()
        {
            return View();
        }
         public IActionResult Cadastrar()
        {
          return View();
        }

        public IActionResult Contatos()
        {
            return View();
        }
        public IActionResult Destino()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}