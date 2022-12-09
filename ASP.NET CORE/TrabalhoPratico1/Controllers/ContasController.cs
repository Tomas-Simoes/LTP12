using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrabalhoPratico1.Context;
using TrabalhoPratico1.Models;

namespace TrabalhoPratico1.Controllers
{
    public class ContasController : Controller
    {
        private readonly AppDbContext _context;

        public ContasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Contas
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Contas.Include(c => c.Agencias).Include(c => c.Clientes);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Contas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Contas == null)
            {
                return NotFound();
            }

            var conta = await _context.Contas
                .Include(c => c.Agencias)
                .Include(c => c.Clientes)
                .FirstOrDefaultAsync(m => m.ContaId == id);
            if (conta == null)
            {
                return NotFound();
            }

            return View(conta);
        }

        // GET: Contas/Create
        public IActionResult Create()
        {
            ViewData["AgenciaId"] = new SelectList(_context.Agencias, "AgenciaId", "Morada");
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteNome");
            return View();
        }

        // POST: Contas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContaId,Saldo,AgenciaId,ClienteId")] Conta conta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(conta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AgenciaId"] = new SelectList(_context.Agencias, "AgenciaId", "Morada", conta.AgenciaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteNome", conta.ClienteId);
            return View(conta);
        }

        // GET: Contas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Contas == null)
            {
                return NotFound();
            }

            var conta = await _context.Contas.FindAsync(id);
            if (conta == null)
            {
                return NotFound();
            }
            ViewData["AgenciaId"] = new SelectList(_context.Agencias, "AgenciaId", "Morada", conta.AgenciaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteNome", conta.ClienteId);
            return View(conta);
        }

        // POST: Contas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContaId,Saldo,AgenciaId,ClienteId")] Conta conta)
        {
            if (id != conta.ContaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(conta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContaExists(conta.ContaId))
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
            ViewData["AgenciaId"] = new SelectList(_context.Agencias, "AgenciaId", "Morada", conta.AgenciaId);
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "ClienteId", "ClienteNome", conta.ClienteId);
            return View(conta);
        }

        // GET: Contas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Contas == null)
            {
                return NotFound();
            }

            var conta = await _context.Contas
                .Include(c => c.Agencias)
                .Include(c => c.Clientes)
                .FirstOrDefaultAsync(m => m.ContaId == id);
            if (conta == null)
            {
                return NotFound();
            }

            return View(conta);
        }

        // POST: Contas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Contas == null)
            {
                return Problem("Entity set 'AppDbContext.Contas'  is null.");
            }
            var conta = await _context.Contas.FindAsync(id);
            if (conta != null)
            {
                _context.Contas.Remove(conta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContaExists(int id)
        {
          return _context.Contas.Any(e => e.ContaId == id);
        }
    }
}
