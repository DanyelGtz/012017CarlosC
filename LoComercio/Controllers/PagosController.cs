using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoComercio.Data;

namespace LoComercio.Controllers
{
    public class PagosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PagosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Pagos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Pagos.Include(p => p.FormaPago);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Pagos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pago = await _context.Pagos.SingleOrDefaultAsync(m => m.Id == id);
            if (pago == null)
            {
                return NotFound();
            }

            return View(pago);
        }

        // GET: Pagos/Create
        public IActionResult Create()
        {
            ViewData["IdFormaPago"] = new SelectList(_context.FormasPagos, "Id", "Nombre");
            return View();
        }

        // POST: Pagos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Anticipo,Fecha,IdFormaPago,Monto")] Pago pago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pago);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdFormaPago"] = new SelectList(_context.FormasPagos, "Id", "Nombre", pago.IdFormaPago);
            return View(pago);
        }

        // GET: Pagos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pago = await _context.Pagos.SingleOrDefaultAsync(m => m.Id == id);
            if (pago == null)
            {
                return NotFound();
            }
            ViewData["IdFormaPago"] = new SelectList(_context.FormasPagos, "Id", "Nombre", pago.IdFormaPago);
            return View(pago);
        }

        // POST: Pagos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Anticipo,Fecha,IdFormaPago,Monto")] Pago pago)
        {
            if (id != pago.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PagoExists(pago.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            ViewData["IdFormaPago"] = new SelectList(_context.FormasPagos, "Id", "Nombre", pago.IdFormaPago);
            return View(pago);
        }

        // GET: Pagos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pago = await _context.Pagos.SingleOrDefaultAsync(m => m.Id == id);
            if (pago == null)
            {
                return NotFound();
            }

            return View(pago);
        }

        // POST: Pagos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var pago = await _context.Pagos.SingleOrDefaultAsync(m => m.Id == id);
            _context.Pagos.Remove(pago);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool PagoExists(long id)
        {
            return _context.Pagos.Any(e => e.Id == id);
        }
    }
}
