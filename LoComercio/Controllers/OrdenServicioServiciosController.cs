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
    public class OrdenServicioServiciosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdenServicioServiciosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: OrdenServicioServicios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OrdenesServicioServicio.Include(o => o.EstadoServicio).Include(o => o.Servicio);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OrdenServicioServicios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenServicioServicio = await _context.OrdenesServicioServicio.SingleOrDefaultAsync(m => m.Id == id);
            if (ordenServicioServicio == null)
            {
                return NotFound();
            }

            return View(ordenServicioServicio);
        }

        // GET: OrdenServicioServicios/Create
        public IActionResult Create()
        {
            ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre");
            ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre");
            return View();
        }

        // POST: OrdenServicioServicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdEdoServicio,IdServicio,PrecioServicio")] OrdenServicioServicio ordenServicioServicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordenServicioServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre", ordenServicioServicio.IdEdoServicio);
            ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre", ordenServicioServicio.IdServicio);
            return View(ordenServicioServicio);
        }

        // GET: OrdenServicioServicios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenServicioServicio = await _context.OrdenesServicioServicio.SingleOrDefaultAsync(m => m.Id == id);
            if (ordenServicioServicio == null)
            {
                return NotFound();
            }
            ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre", ordenServicioServicio.IdEdoServicio);
            ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre", ordenServicioServicio.IdServicio);
            return View(ordenServicioServicio);
        }

        // POST: OrdenServicioServicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,IdEdoServicio,IdServicio,PrecioServicio")] OrdenServicioServicio ordenServicioServicio)
        {
            if (id != ordenServicioServicio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordenServicioServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenServicioServicioExists(ordenServicioServicio.Id))
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
            ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre", ordenServicioServicio.IdEdoServicio);
            ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre", ordenServicioServicio.IdServicio);
            return View(ordenServicioServicio);
        }

        // GET: OrdenServicioServicios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenServicioServicio = await _context.OrdenesServicioServicio.SingleOrDefaultAsync(m => m.Id == id);
            if (ordenServicioServicio == null)
            {
                return NotFound();
            }

            return View(ordenServicioServicio);
        }

        // POST: OrdenServicioServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var ordenServicioServicio = await _context.OrdenesServicioServicio.SingleOrDefaultAsync(m => m.Id == id);
            _context.OrdenesServicioServicio.Remove(ordenServicioServicio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool OrdenServicioServicioExists(long id)
        {
            return _context.OrdenesServicioServicio.Any(e => e.Id == id);
        }
    }
}
