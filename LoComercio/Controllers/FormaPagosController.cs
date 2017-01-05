using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoDesbloqueo.Data;

namespace LoDesbloqueo.Controllers
{
    public class FormaPagosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormaPagosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: FormaPagos
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormasPagos.ToListAsync());
        }

        // GET: FormaPagos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPago = await _context.FormasPagos.SingleOrDefaultAsync(m => m.Id == id);
            if (formaPago == null)
            {
                return NotFound();
            }

            return View(formaPago);
        }

        // GET: FormaPagos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormaPagos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] FormaPago formaPago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formaPago);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(formaPago);
        }

        // GET: FormaPagos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPago = await _context.FormasPagos.SingleOrDefaultAsync(m => m.Id == id);
            if (formaPago == null)
            {
                return NotFound();
            }
            return View(formaPago);
        }

        // POST: FormaPagos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] FormaPago formaPago)
        {
            if (id != formaPago.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formaPago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormaPagoExists(formaPago.Id))
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
            return View(formaPago);
        }

        // GET: FormaPagos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaPago = await _context.FormasPagos.SingleOrDefaultAsync(m => m.Id == id);
            if (formaPago == null)
            {
                return NotFound();
            }

            return View(formaPago);
        }

        // POST: FormaPagos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var formaPago = await _context.FormasPagos.SingleOrDefaultAsync(m => m.Id == id);
            _context.FormasPagos.Remove(formaPago);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool FormaPagoExists(long id)
        {
            return _context.FormasPagos.Any(e => e.Id == id);
        }
    }
}
