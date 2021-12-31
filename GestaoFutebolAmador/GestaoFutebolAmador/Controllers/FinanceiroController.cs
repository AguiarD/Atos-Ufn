using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoFutebolAmador;
using GestaoFutebolAmador.Models;

namespace GestaoFutebolAmador.Controllers
{
    public class FinanceiroController : Controller
    {
        private readonly Contexto _context;

        public FinanceiroController(Contexto context)
        {
            _context = context;
        }

        // GET: Financeiro
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Financeiros.Include(f => f.Contas).Include(f => f.Jogadores);
            return View(await contexto.ToListAsync());
        }

        // GET: Financeiro/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financeiro = await _context.Financeiros
                .Include(f => f.Contas)
                .Include(f => f.Jogadores)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (financeiro == null)
            {
                return NotFound();
            }

            return View(financeiro);
        }

        // GET: Financeiro/Create
        public IActionResult Create()
        {
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "DescConta");
            ViewData["JogadoresId"] = new SelectList(_context.Jogadores, "Id", "NomeJogador");
            return View();
        }

        // POST: Financeiro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Valor,ObsLancamento,DtPrevisao,DtBaixa,Inativo,ContaId,JogadoresId")] Financeiro financeiro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(financeiro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "Id", financeiro.ContaId);
            ViewData["JogadoresId"] = new SelectList(_context.Jogadores, "Id", "Id", financeiro.JogadoresId);
            return View(financeiro);
        }

        // GET: Financeiro/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financeiro = await _context.Financeiros.FindAsync(id);
            if (financeiro == null)
            {
                return NotFound();
            }
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "Id", financeiro.ContaId);
            ViewData["JogadoresId"] = new SelectList(_context.Jogadores, "Id", "Id", financeiro.JogadoresId);
            return View(financeiro);
        }

        // POST: Financeiro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Valor,ObsLancamento,DtPrevisao,DtBaixa,Inativo,ContaId,JogadoresId")] Financeiro financeiro)
        {
            if (id != financeiro.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(financeiro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinanceiroExists(financeiro.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContaId"] = new SelectList(_context.Contas, "Id", "Id", financeiro.ContaId);
            ViewData["JogadoresId"] = new SelectList(_context.Jogadores, "Id", "Id", financeiro.JogadoresId);
            return View(financeiro);
        }

        // GET: Financeiro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financeiro = await _context.Financeiros
                .Include(f => f.Contas)
                .Include(f => f.Jogadores)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (financeiro == null)
            {
                return NotFound();
            }

            return View(financeiro);
        }

        // POST: Financeiro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var financeiro = await _context.Financeiros.FindAsync(id);
            _context.Financeiros.Remove(financeiro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinanceiroExists(int id)
        {
            return _context.Financeiros.Any(e => e.Id == id);
        }
    }
}
