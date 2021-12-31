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
    public class ScoutController : Controller
    {
        private readonly Contexto _context;

        public ScoutController(Contexto context)
        {
            _context = context;
        }

        // GET: Scout
        public async Task<IActionResult> Index()
        {
            var contexto = _context.Scouts.Include(s => s.Jogadores);
            return View(await contexto.ToListAsync());
        }

        // GET: Scout/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scout = await _context.Scouts
                .Include(s => s.Jogadores)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scout == null)
            {
                return NotFound();
            }

            return View(scout);
        }

        // GET: Scout/Create
        public IActionResult Create()
        {
            ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "Id");
            return View();
        }

        // POST: Scout/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DtPartida,Presenca,Resultado,Ponto,Gol,Assistencia,ObsScout,Inativo,JogadorId,ParametrosId")] Scout scout)
        {
            if (ModelState.IsValid)
            {
                _context.Add(scout);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "Id", scout.JogadorId);
            return View(scout);
        }

        // GET: Scout/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scout = await _context.Scouts.FindAsync(id);
            if (scout == null)
            {
                return NotFound();
            }
            ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "Id", scout.JogadorId);
            return View(scout);
        }

        // POST: Scout/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DtPartida,Presenca,Resultado,Ponto,Gol,Assistencia,ObsScout,Inativo,JogadorId,ParametrosId")] Scout scout)
        {
            if (id != scout.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(scout);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ScoutExists(scout.Id))
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
            ViewData["JogadorId"] = new SelectList(_context.Jogadores, "Id", "Id", scout.JogadorId);
            return View(scout);
        }

        // GET: Scout/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var scout = await _context.Scouts
                .Include(s => s.Jogadores)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (scout == null)
            {
                return NotFound();
            }

            return View(scout);
        }

        // POST: Scout/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var scout = await _context.Scouts.FindAsync(id);
            _context.Scouts.Remove(scout);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ScoutExists(int id)
        {
            return _context.Scouts.Any(e => e.Id == id);
        }
    }
}
