using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebAppConsumindoDadosEmJson.Models;

namespace WebAppConsumindoDadosEmJson.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }







        //Mostrar apenas um objeto...
        //var resultado = new
        //{
        //    Nome = "Relinton Pinheiro",
        //    Sitio = "https://github.com/Relinton"
        //};

        public ActionResult Index()
        {
            return View();
        }
        public JsonResult BuscarDados()
        {
            //Mostrando uma lista de objetos...
            List<Object> resultado = new List<object>();
            resultado.Add(new
            {
                Nome = "Relinton Pinheiro",
                Sitio = "https://github.com/Relinton"
            });
            resultado.Add(new
            {
                Nome = "Relinton Pinheiro",
                Sitio = "https://github.com/Relinton"
            });
            resultado.Add(new
            {
                Nome = "Relinton Pinheiro",
                Sitio = "https://github.com/Relinton"
            });
            return Json(resultado);
        }

        [HttpPost]
        public JsonResult GetDados(int quantidade)
        {
            List<Object> resultado = new List<object>();
            for (int i = 0; i < quantidade; i++)
            {
                resultado.Add(new { Nome = "Item " + i.ToString("0") });
            }
            return Json(resultado);
        }










        public IActionResult Privacy()
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
