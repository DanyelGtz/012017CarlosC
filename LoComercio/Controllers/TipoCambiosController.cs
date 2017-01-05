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
    public class TipoCambiosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoCambiosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: TipoCambios
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposCambio.ToListAsync());
        }

        // GET: TipoCambios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoCambio = await _context.TiposCambio.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoCambio == null)
            {
                return NotFound();
            }

            return View(tipoCambio);
        }

        // GET: TipoCambios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoCambios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoCambio tipoCambio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoCambio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tipoCambio);
        }

        // GET: TipoCambios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoCambio = await _context.TiposCambio.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoCambio == null)
            {
                return NotFound();
            }
            return View(tipoCambio);
        }

        // POST: TipoCambios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] TipoCambio tipoCambio)
        {
            if (id != tipoCambio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoCambio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoCambioExists(tipoCambio.Id))
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
            return View(tipoCambio);
        }

        // GET: TipoCambios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoCambio = await _context.TiposCambio.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoCambio == null)
            {
                return NotFound();
            }

            return View(tipoCambio);
        }

        // POST: TipoCambios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var tipoCambio = await _context.TiposCambio.SingleOrDefaultAsync(m => m.Id == id);
            _context.TiposCambio.Remove(tipoCambio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TipoCambioExists(long id)
        {
            return _context.TiposCambio.Any(e => e.Id == id);
        }
    }
}
