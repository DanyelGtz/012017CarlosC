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
    public class SolicitudRefaccionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SolicitudRefaccionsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: SolicitudRefaccions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SolicitudRefacciones.Include(s => s.EstadoRefaccion).Include(s => s.Refaccion);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SolicitudRefaccions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudRefaccion = await _context.SolicitudRefacciones.SingleOrDefaultAsync(m => m.Id == id);
            if (solicitudRefaccion == null)
            {
                return NotFound();
            }

            return View(solicitudRefaccion);
        }

        // GET: SolicitudRefaccions/Create
        public IActionResult Create()
        {
            ViewData["IdEdoRefaccion"] = new SelectList(_context.EstadosRefacciones, "Id", "Nombre");
            ViewData["IdRefaccion"] = new SelectList(_context.Refacciones, "Id", "Nombre");
            return View();
        }

        // POST: SolicitudRefaccions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cantidad,Fecha,IdEdoRefaccion,IdRefaccion,IdUsuario")] SolicitudRefaccion solicitudRefaccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitudRefaccion);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdEdoRefaccion"] = new SelectList(_context.EstadosRefacciones, "Id", "Nombre", solicitudRefaccion.IdEdoRefaccion);
            ViewData["IdRefaccion"] = new SelectList(_context.Refacciones, "Id", "Nombre", solicitudRefaccion.IdRefaccion);
            return View(solicitudRefaccion);
        }

        // GET: SolicitudRefaccions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudRefaccion = await _context.SolicitudRefacciones.SingleOrDefaultAsync(m => m.Id == id);
            if (solicitudRefaccion == null)
            {
                return NotFound();
            }
            ViewData["IdEdoRefaccion"] = new SelectList(_context.EstadosRefacciones, "Id", "Nombre", solicitudRefaccion.IdEdoRefaccion);
            ViewData["IdRefaccion"] = new SelectList(_context.Refacciones, "Id", "Nombre", solicitudRefaccion.IdRefaccion);
            return View(solicitudRefaccion);
        }

        // POST: SolicitudRefaccions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Cantidad,Fecha,IdEdoRefaccion,IdRefaccion,IdUsuario")] SolicitudRefaccion solicitudRefaccion)
        {
            if (id != solicitudRefaccion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitudRefaccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudRefaccionExists(solicitudRefaccion.Id))
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
            ViewData["IdEdoRefaccion"] = new SelectList(_context.EstadosRefacciones, "Id", "Nombre", solicitudRefaccion.IdEdoRefaccion);
            ViewData["IdRefaccion"] = new SelectList(_context.Refacciones, "Id", "Nombre", solicitudRefaccion.IdRefaccion);
            return View(solicitudRefaccion);
        }

        // GET: SolicitudRefaccions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudRefaccion = await _context.SolicitudRefacciones.SingleOrDefaultAsync(m => m.Id == id);
            if (solicitudRefaccion == null)
            {
                return NotFound();
            }

            return View(solicitudRefaccion);
        }

        // POST: SolicitudRefaccions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var solicitudRefaccion = await _context.SolicitudRefacciones.SingleOrDefaultAsync(m => m.Id == id);
            _context.SolicitudRefacciones.Remove(solicitudRefaccion);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool SolicitudRefaccionExists(long id)
        {
            return _context.SolicitudRefacciones.Any(e => e.Id == id);
        }
    }
}
