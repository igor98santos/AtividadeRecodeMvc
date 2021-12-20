#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entrega.Models;

namespace Entrega.Controllers
{
    public class VoosController : Controller
    {
        private readonly Context _context;

        public VoosController(Context context)
        {
            _context = context;
        }

        // GET: Voos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Voo.ToListAsync());
        }

        // GET: Voos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voo = await _context.Voo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voo == null)
            {
                return NotFound();
            }

            return View(voo);
        }

        // GET: Voos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Voos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numero_Voo,NomeDestino,CPF,CartaoDeCredito")] Voo voo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(voo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(voo);
        }

        // GET: Voos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voo = await _context.Voo.FindAsync(id);
            if (voo == null)
            {
                return NotFound();
            }
            return View(voo);
        }

        // POST: Voos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero_Voo,NomeDestino,CPF,CartaoDeCredito")] Voo voo)
        {
            if (id != voo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(voo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VooExists(voo.Id))
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
            return View(voo);
        }

        // GET: Voos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var voo = await _context.Voo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (voo == null)
            {
                return NotFound();
            }

            return View(voo);
        }

        // POST: Voos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var voo = await _context.Voo.FindAsync(id);
            _context.Voo.Remove(voo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VooExists(int id)
        {
            return _context.Voo.Any(e => e.Id == id);
        }
    }
}
