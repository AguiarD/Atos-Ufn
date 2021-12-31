using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFinanceira.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public void Lancamentos(object sender, EventArgs e)
        {
            //Contexto contexto = new Contexto();
            Bd bd = new Bd();

            string sql = "select * from Lancamentos";

            DataTable dt = new DataTable();

            //List<Financeiro> financeiros = (from Financeiro f in contexto.Financeiros select f).ToList<Financeiro>();

            dt = bd.executarConsultaGenerica(sql);


            //return View(dt);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
