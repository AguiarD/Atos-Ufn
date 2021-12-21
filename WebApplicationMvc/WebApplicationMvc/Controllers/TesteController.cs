using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace WebApplicationMvc.Controllers
{
    public class TesteController : Controller
    {
        public ActionResult Index()
        {
            //return "Oi gente, como estão?";
            return View();
        }

        public string Welcome()
        {
            return "Bem vindo ao meu método de boas vindas do meu controller";
        }

        public IActionResult MostrarNome(string nome, string sobrenome, int repete = 1)
        {
            //return HtmlEncoder.Default.Encode("Meu nome eh " + nome);
            ViewData["Nome"] = "Nome: " + nome;
            ViewData["Sobrenome"] = "Sobrenome: " + sobrenome;
            ViewData["repete"] = repete;
            return View();
        }
    }
}
