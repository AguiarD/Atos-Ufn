using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoFinanceira;
using GestaoFinanceira.Models;
using GestaoFinanceira.Repository;

namespace GestaoFinanceira.Controllers
{
    public class LancamentosController : Controller
    {
        // GET: Funcionario/SelecionarFuncionarios
        public ActionResult SelecionarLancamentos()
        {
            var funcRepository = new LancamentoRepository();
            ModelState.Clear();

            return View(funcRepository.SelecionarLancamentos());
        }

        // GET: Funcionario/AdicionarFuncionario
        public ActionResult AdicionarLancamento()
        {
            return View();
        }

        // POST: Funcionario/AdicionarFuncionario
        [HttpPost]
        public ActionResult AdicionarLancamento(Lancamento func)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var lancRepository = new LancamentoRepository();

                    if (lancRepository.AdicionarLancamento(func))
                    {
                        ViewBag.Message = "Lancamento criado com sucesso!";
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/AtualizarFuncionario/5
        public ActionResult AtualizarLancamento(int id)
        {
            var lancRepository = new LancamentoRepository();

            return View(lancRepository.SelecionarLancamentos()
                            .Find(lanc => lanc.id == id));
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        public ActionResult AtualizarLancamento(int id, Lancamento lancamento)
        {
            try
            {
                var lancRepository = new LancamentoRepository();
                lancRepository.AtualizarLancamento(lancamento);

                return RedirectToAction("SelecionarLancamentos");
            }
            catch
            {
                return View();
            }
        }

        // GET: Funcionario/ExcluirFuncionario/5
        public ActionResult ExcluirLancamento(int id)
        {
            try
            {
                var lancRepository = new LancamentoRepository();

                if (lancRepository.ExcluirLancamento(id))
                {
                    ViewBag.AlertMsg = "Lancamento excluído com sucesso.";
                }

                return RedirectToAction("SelecionarLancamentos");
            }
            catch
            {
                return View();
            }
        }
    }
}
