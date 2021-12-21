using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMvc.Models;

namespace WebApplicationMvc.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InstanciaPessoa(string nome, string email, string senha)
        {
            Pessoa p = new Pessoa();
            p.nome = nome;
            p.email = email;
            p.senha = senha;

            ViewData["nome"] = p.nome;
            ViewData["email"] = p.email;
            return View();
        }
    }
}
