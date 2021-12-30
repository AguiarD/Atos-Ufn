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
    public class JogadoresController : Controller
    {
        private readonly Contexto _context;

        public JogadoresController(Contexto context)
        {
            _context = context;
        }

        // GET: Jogadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Jogadores.ToListAsync());
        }

        // GET: Jogadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogador = await _context.Jogadores
                .FirstOrDefaultAsync(m => m.id == id);
            if (jogador == null)
            {
                return NotFound();
            }

            return View(jogador);
        }

        // GET: Jogadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jogadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome_jogador,mensalista,obs_mensalista,inativo")] Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jogador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jogador);
        }

        // GET: Jogadores/Edit/5
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogador = _context.Jogadores.Find(id);
            if (jogador == null)
            {
                return NotFound();
            }
            return View(jogador);
        }

        // POST: Jogadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, JogadorInput jogador)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jogador);
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JogadorExists(id))
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
            return View(jogador);
        }

        // GET: Jogadores/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jogador = _context.Jogadores
                .FirstOrDefault(m => m.id == id);
            if (jogador == null)
            {
                return NotFound();
            }

            return View(jogador);
        }

        // POST: Jogadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var jogador = _context.Jogadores.Find(id);
            _context.Jogadores.Remove(jogador);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool JogadorExists(int id)
        {
            return _context.Jogadores.Any(e => e.id == id);
        }
    }
}
