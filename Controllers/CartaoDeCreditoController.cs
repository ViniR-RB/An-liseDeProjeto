using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prova_AnaliseProjeto.Models;

namespace prova_AnaliseProjeto.Controllers
{
    public class CartaoDeCreditoController : Controller
    {
        private readonly Context _context;

        public CartaoDeCreditoController(Context context)
        {
            _context = context;
        }

        // GET: CartaoDeCredito
        public async Task<IActionResult> Index()
        {
            return View(await _context.CartaoDeCredito.ToListAsync());
        }

        // GET: CartaoDeCredito/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaoDeCredito = await _context.CartaoDeCredito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartaoDeCredito == null)
            {
                return NotFound();
            }

            return View(cartaoDeCredito);
        }

        // GET: CartaoDeCredito/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CartaoDeCredito/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("numero,Id,DateTime,Discriminator,Valor")] CartaoDeCredito cartaoDeCredito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartaoDeCredito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cartaoDeCredito);
        }

        // GET: CartaoDeCredito/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaoDeCredito = await _context.CartaoDeCredito.FindAsync(id);
            if (cartaoDeCredito == null)
            {
                return NotFound();
            }
            return View(cartaoDeCredito);
        }

        // POST: CartaoDeCredito/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("numero,Id,DateTime,Discriminator,Valor")] CartaoDeCredito cartaoDeCredito)
        {
            if (id != cartaoDeCredito.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartaoDeCredito);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartaoDeCreditoExists(cartaoDeCredito.Id))
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
            return View(cartaoDeCredito);
        }

        // GET: CartaoDeCredito/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartaoDeCredito = await _context.CartaoDeCredito
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cartaoDeCredito == null)
            {
                return NotFound();
            }

            return View(cartaoDeCredito);
        }

        // POST: CartaoDeCredito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartaoDeCredito = await _context.CartaoDeCredito.FindAsync(id);
            _context.CartaoDeCredito.Remove(cartaoDeCredito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartaoDeCreditoExists(int id)
        {
            return _context.CartaoDeCredito.Any(e => e.Id == id);
        }
    }
}
