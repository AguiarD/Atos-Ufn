using GestaoFutebolAmador.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador.Controllers
{
    public class NetController : Controller
    {
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

        public IActionResult JogadorId(int id)
        {
            Contexto contexto = new Contexto();
            Jogador? p = contexto.Jogadores.Find(id);

            return View(p);
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

        public IActionResult Financeiros()
        {
            Contexto contexto = new Contexto();

            List<Financeiro> financeiros = (from Financeiro f in contexto.Financeiros select f).ToList<Financeiro>();

            return View(financeiros);
        }

        //public IActionResult LancamentosAno(int ano)
        //{
        //    Contexto contexto = new Contexto();

        //}

        public IActionResult Scouts()
        {
            Contexto contexto = new Contexto();

            List<Scout> scouts = (from Scout f in contexto.Scouts select f).ToList<Scout>();

            return View(scouts);
        }
    }
}
