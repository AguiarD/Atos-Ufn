#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoFinanceira;
using GestaoFinanceira.Models;
using Microsoft.AspNetCore.Authorization;

namespace GestaoFinanceira.Controllers
{
    public class LancamentoController : Controller
    {
        private readonly Contexto _context;

        public LancamentoController(Contexto context)
        {
            _context = context;
        }

        //[Authorize]
        // GET: Lancamento
        public async Task<IActionResult> Index(string? mes, string? ano)
        {
            if (mes == null)
            {
                mes = Convert.ToString(DateTime.Now.Month);
            }

            if (ano == null)
            {
                ano = Convert.ToString(DateTime.Now.Year);
            }


            ViewBag.Ano = ano; //Passar variavel para view
            ViewBag.Mes = mes;
            var contexto = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos).OrderBy(l => l.TipoId).Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano)).Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes));
            return View(await contexto.ToListAsync());
        }

        public async Task<IActionResult> Ano(string ano)
        {
            //ano = "2021";
            var contexto = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos).Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano));
            return View(await contexto.ToListAsync());
        }

        public async Task<IActionResult> Resumo(string? mes, string? ano)
        {
            //ano = 2021;  //ano precisa vir de formulario
            //var contexto = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
            //    .Where(l => l.DtPrevisao.Year == ano)
            //    //.Where(l => l.Inativo == null)
            //    .Sum(l => l.Valor);

            if (mes == null)
            {
                mes = Convert.ToString(DateTime.Now.Month);
            }

            if (ano == null)
            {
                ano = Convert.ToString(DateTime.Now.Year);
            }

            //ano = 2021;  //ano precisa vir de formulario
            ViewBag.Mes = mes;
            ViewBag.Ano = ano;

            //RESUMO
            var contextoReceita = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.TipoId == 1)
                //.Where(l => l.Inativo == null)
                .Sum(l => l.Valor);
            ViewBag.Receita = contextoReceita;
            //ViewData["dReceita"] = contextoReceita;


            var contextoDespesa = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.TipoId == 2)
                //.Where(l => l.Inativo == null)
                .Sum(l => l.Valor);
            contextoDespesa = contextoDespesa * -1;
            ViewBag.Despesa = contextoDespesa;
            //ViewData["dDespesa"] = contextoDespesa;

            var saldoGeral = contextoReceita + contextoDespesa;
            ViewBag.SaldoGeral = saldoGeral;



            //RESUMO ABERTO

            var contextoReceitaAberto = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.TipoId == 1)
                .Where(l => l.DtBaixa == null)
                .Sum(l => l.Valor);
            ViewBag.ReceitaAberto = contextoReceitaAberto;

            var contextoDespesaAberto = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.TipoId == 2)
                .Where(l => l.DtBaixa == null)
                .Sum(l => l.Valor);
            contextoDespesaAberto = contextoDespesaAberto * -1;
            ViewBag.DespesaAberto = contextoDespesaAberto;

            var saldoAberto = contextoReceitaAberto + contextoDespesaAberto;
            ViewBag.SaldoAberto = saldoAberto;


            //Grupo Pessoa
            var grupoPessoa = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.GrupoId == 1)
                .Sum(l => l.Valor)
                //.GroupBy(l => l.GrupoId)
                //.Select(g => new { GrupoId = g.Key, Valor = g.Sum(l => l.Valor) })
                ;

            ViewBag.GrupoPessoal = grupoPessoa;


            //Grupo Casa
            var grupoCasa = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.GrupoId == 2)
                .Sum(l => l.Valor)
                //.GroupBy(l => l.GrupoId)
                //.Select(g => new { GrupoId = g.Key, Valor = g.Sum(l => l.Valor) })
                ;

            ViewBag.GrupoCasa = grupoCasa;


            //Grupo Trabalho
            var grupoTrabalho = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.GrupoId == 3)
                .Sum(l => l.Valor)
                //.GroupBy(l => l.GrupoId)
                //.Select(g => new { GrupoId = g.Key, Valor = g.Sum(l => l.Valor) })
                ;

            ViewBag.GrupoTrabalho = grupoTrabalho;


            //Grupo Transporte
            var grupoTransporte = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.GrupoId == 4)
                .Sum(l => l.Valor)
                //.GroupBy(l => l.GrupoId)
                //.Select(g => new { GrupoId = g.Key, Valor = g.Sum(l => l.Valor) })
                ;

            ViewBag.GrupoTransporte = grupoTransporte;


            //Grupo Reserva
            var grupoReserva = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.GrupoId == 5)
                .Sum(l => l.Valor)
                //.GroupBy(l => l.GrupoId)
                //.Select(g => new { GrupoId = g.Key, Valor = g.Sum(l => l.Valor) })
                ;

            ViewBag.GrupoReserva = grupoReserva;


            //Grupo CartaoD10
            var grupoCartaoD10 = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.GrupoId == 6)
                .Sum(l => l.Valor)
                //.GroupBy(l => l.GrupoId)
                //.Select(g => new { GrupoId = g.Key, Valor = g.Sum(l => l.Valor) })
                ;

            ViewBag.GrupoCartaoD10 = grupoCartaoD10;

            //Grupo CartaoD15
            var grupoCartaoD15 = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.GrupoId == 7)
                .Sum(l => l.Valor)
                //.GroupBy(l => l.GrupoId)
                //.Select(g => new { GrupoId = g.Key, Valor = g.Sum(l => l.Valor) })
                ;

            ViewBag.GrupoCartaoD15 = grupoCartaoD15;

            //Grupo Pet
            var grupoPet = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
                .Where(l => l.DtPrevisao.Year == Convert.ToInt32(ano))
                .Where(l => l.DtPrevisao.Month == Convert.ToInt32(mes))
                .Where(l => l.GrupoId == 8)
                .Sum(l => l.Valor)
                //.GroupBy(l => l.GrupoId)
                //.Select(g => new { GrupoId = g.Key, Valor = g.Sum(l => l.Valor) })
                ;

            ViewBag.GrupoPet = grupoPet;

            return View();
        }

        //public decimal Receita(int ano)
        //{
        //    ano = 2021;  //ano precisa vir de formulario
        //    var contexto = _context.Lancamentos.Include(l => l.Contas).Include(l => l.Grupos).Include(l => l.Tipos)
        //        .Where(l => l.DtPrevisao.Year == ano)
        //        .Where(l => l.TipoId == 1)
        //        //.Where(l => l.Inativo == null)
        //        .Sum(l => l.Valor);
        //    ViewBag.Receita = contexto;

        //    return contexto;
        //}



        // GET: Lancamento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos
                .Include(l => l.Contas)
                .Include(l => l.Grupos)
                .Include(l => l.Tipos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // GET: Lancamento/Create
        public IActionResult Create()
        {
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta");
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "DescGrupo");
            ViewData["TipoId"] = new SelectList(_context.Tipos, "Id", "DescTipo");
            return View();
        }

        // POST: Lancamento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TipoId,Valor,GrupoId,ContaId,ObsLancamento,DtPrevisao,DtBaixa,Inativo")] Lancamento lancamento)
        {
            //if (ModelState.IsValid)
            //{
                _context.Add(lancamento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            //}
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta", lancamento.ContaId);
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "DescGrupo", lancamento.GrupoId);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "Id", "DescTipo", lancamento.TipoId);
            return View(lancamento);
        }

        // GET: Lancamento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos.FindAsync(id);
            if (lancamento == null)
            {
                return NotFound();
            }
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta", lancamento.ContaId);
            ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "DescGrupo", lancamento.GrupoId);
            ViewData["TipoId"] = new SelectList(_context.Tipos, "Id", "DescTipo", lancamento.TipoId);
            return View(lancamento);
        }

        // POST: Lancamento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TipoId,Valor,GrupoId,ContaId,ObsLancamento,DtPrevisao,DtBaixa,Inativo")] Lancamento lancamento)
        {
            if (id != lancamento.Id)
            {
                return NotFound();
            }

            //if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(lancamento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LancamentoExists(lancamento.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            //}
            //ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta", lancamento.ContaId);
            //ViewData["GrupoId"] = new SelectList(_context.Grupos, "Id", "DescGrupo", lancamento.GrupoId);
            //ViewData["TipoId"] = new SelectList(_context.Tipos, "Id", "DescTipo", lancamento.TipoId);
            //return View(lancamento);
        }

        // GET: Lancamento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lancamento = await _context.Lancamentos
                .Include(l => l.Contas)
                .Include(l => l.Grupos)
                .Include(l => l.Tipos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lancamento == null)
            {
                return NotFound();
            }

            return View(lancamento);
        }

        // POST: Lancamento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lancamento = await _context.Lancamentos.FindAsync(id);
            _context.Lancamentos.Remove(lancamento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LancamentoExists(int id)
        {
            return _context.Lancamentos.Any(e => e.Id == id);
        }
    }
}
