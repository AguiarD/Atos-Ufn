using GestaoFutebolAmador.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador.Controllers
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

        public IActionResult Jogadores()
        {
            Contexto contexto = new Contexto();

            List<Jogador> jogadores = (from Jogador j in contexto.Jogadores select j).ToList<Jogador>();

            return View(jogadores);
        }

        public IActionResult Parametros()
        {
            Contexto contexto = new Contexto();

            List<Parametro> parametros = (from Parametro p in contexto.Parametros select p).ToList<Parametro>();

            return View(parametros);
        }

        public IActionResult Contas()
        {
            Contexto contexto = new Contexto();

            List<Conta> contas = (from Conta c in contexto.Contas select c).ToList<Conta>();

            return View(contas);
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
