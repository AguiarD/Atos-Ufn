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
    public class ContaController : Controller
    {
        private readonly Contexto _context;

        public ContaController(Contexto context)
        {
            _context = context;
        }

        // GET: Conta
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contas.ToListAsync());
        }

        // GET: Conta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conta = await _context.Contas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conta == null)
            {
                return NotFound();
            }

            return View(conta);
        }

        // GET: Conta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Conta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DescConta,TipoConta,ObsConta,Inativo")] Conta conta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conta);
                await _context.SaveChangesAsync();
                _context.Dispose();
                return RedirectToAction(nameof(Index));
            }
            return View(conta);
        }

        // GET: Conta/Edit/5
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conta = await _context.Contas.FindAsync(id);
            if (conta == null)
            {
                return NotFound();
            }

            return View(conta);
        }

        // POST: Conta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,DescConta,TipoConta,ObsConta,Inativo")] Conta conta)
        {
            //conta = _context.Contas.Find(conta.Id);

            try
            {
                //conta.Id = id;
                //_context.Contas.AsNoTracking();
                //_context.Entry(conta).State=EntityState.Detached;
                //_context.Attach(conta);
                _context.Update(conta);
                _context.SaveChanges();

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContaExists(conta.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            _context.Dispose();
            return RedirectToAction(nameof(Index));

            //return View(conta);
        }

        // GET: Conta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var conta = await _context.Contas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (conta == null)
            {
                return NotFound();
            }

            return View(conta);
        }

        // POST: Conta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var conta = await _context.Contas.FindAsync(id);
            _context.Contas.Remove(conta);
            await _context.SaveChangesAsync();
            _context.Dispose();
            return RedirectToAction(nameof(Index));
        }

        private bool ContaExists(int id)
        {
            return _context.Contas.Any(e => e.Id == id);
        }
    }
}
