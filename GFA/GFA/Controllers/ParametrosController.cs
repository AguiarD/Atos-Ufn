using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GFA;
using GFA.Models;

namespace GFA.Controllers
{
    public class ParametrosController : Controller
    {
        private readonly Contexto _context;

        public ParametrosController(Contexto context)
        {
            _context = context;
        }

        // GET: Parametros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parametros.ToListAsync());
        }

        // GET: Parametros/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametro = await _context.Parametros
                .FirstOrDefaultAsync(m => m.id == id);
            if (parametro == null)
            {
                return NotFound();
            }

            return View(parametro);
        }

        // GET: Parametros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parametros/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,desc_parametro,ponto,inativo")] Parametro parametro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parametro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parametro);
        }

        // GET: Parametros/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametro = await _context.Parametros.FindAsync(id);
            if (parametro == null)
            {
                return NotFound();
            }
            return View(parametro);
        }

        // POST: Parametros/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("id,desc_parametro,ponto,inativo")] Parametro parametro)
        {
            if (id != parametro.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parametro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParametroExists(parametro.id))
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
            return View(parametro);
        }

        // GET: Parametros/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametro = await _context.Parametros
                .FirstOrDefaultAsync(m => m.id == id);
            if (parametro == null)
            {
                return NotFound();
            }

            return View(parametro);
        }

        // POST: Parametros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var parametro = await _context.Parametros.FindAsync(id);
            _context.Parametros.Remove(parametro);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParametroExists(string id)
        {
            return _context.Parametros.Any(e => e.id == id);
        }
    }
}
