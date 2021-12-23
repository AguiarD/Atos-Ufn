using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAulaMVCcomEntity.Models;

namespace WebApplicationAulaMVCcomEntity.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] //facultativo
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Pessoas()
        {
            Contexto contexto = new Contexto();

            List<Pessoa> pessoas = (from Pessoa p in 
                                        contexto.Pessoas select p)
                                        .Include(e => e.Emails)
                                        .ToList<Pessoa>();
            return View(pessoas);
        }

        public IActionResult PessoaId(int id)
        {
            Contexto contexto = new Contexto();
            Pessoa? p = contexto.Pessoas.Find(id);

            return View(p);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Pessoa p)
        {
            Contexto contexto = new Contexto();

            contexto.Pessoas.Add(p);
            contexto.SaveChanges();

            return RedirectToAction("PessoaId", new { id = p.id }); //Para direcionar para o id da pessoa depois de adcionar no banco. return View("Pessoa")
        }
    }
}
