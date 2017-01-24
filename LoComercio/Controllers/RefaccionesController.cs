using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoDesbloqueo.Data;

namespace LoComercio.Controllers
{
    public class RefaccionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RefaccionesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Refacciones
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Refacciones.Include(r => r.Modelo);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Refacciones/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refaccion = await _context.Refacciones.SingleOrDefaultAsync(m => m.Id == id);
            if (refaccion == null)
            {
                return NotFound();
            }

            return View(refaccion);
        }

        // GET: Refacciones/Create
        public IActionResult Create()
        {
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico");
            return View();
        }

        // POST: Refacciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CantMax,CantMin,Existencia,IdModelo,Nombre")] Refaccion refaccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(refaccion);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico", refaccion.IdModelo);
            return View(refaccion);
        }

        // GET: Refacciones/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refaccion = await _context.Refacciones.SingleOrDefaultAsync(m => m.Id == id);
            if (refaccion == null)
            {
                return NotFound();
            }
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico", refaccion.IdModelo);
            return View(refaccion);
        }

        // POST: Refacciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,CantMax,CantMin,Existencia,IdModelo,Nombre")] Refaccion refaccion)
        {
            if (id != refaccion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(refaccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RefaccionExists(refaccion.Id))
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
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico", refaccion.IdModelo);
            return View(refaccion);
        }

        // GET: Refacciones/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var refaccion = await _context.Refacciones.SingleOrDefaultAsync(m => m.Id == id);
            if (refaccion == null)
            {
                return NotFound();
            }

            return View(refaccion);
        }

        // POST: Refacciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var refaccion = await _context.Refacciones.SingleOrDefaultAsync(m => m.Id == id);
            _context.Refacciones.Remove(refaccion);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool RefaccionExists(long id)
        {
            return _context.Refacciones.Any(e => e.Id == id);
        }
    }
}
