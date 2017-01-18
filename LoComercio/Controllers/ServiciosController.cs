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
    public class ServiciosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiciosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Servicios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Servicios.Include(s => s.TipoServicio);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Servicios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicios.SingleOrDefaultAsync(m => m.Id == id);
            if (servicio == null)
            {
                return NotFound();
            }

            return View(servicio);
        }

        // GET: Servicios/Create
        public IActionResult Create()
        {
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico");
            ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre");
            return View();
        }

        // POST: Servicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdModelo,IdTipoServicio,Nombre,PrecioMaximo,PrecioMinimo,PrecioSugerido")] Servicio servicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(servicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre", servicio.IdTipoServicio);
            return View(servicio);
        }

        // GET: Servicios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicios.SingleOrDefaultAsync(m => m.Id == id);
            if (servicio == null)
            {
                return NotFound();
            }
            ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre", servicio.IdTipoServicio);
            return View(servicio);
        }

        // POST: Servicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,IdModelo,IdTipoServicio,Nombre,PrecioMaximo,PrecioMinimo,PrecioSugerido")] Servicio servicio)
        {
            if (id != servicio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServicioExists(servicio.Id))
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
            ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre", servicio.IdTipoServicio);
            return View(servicio);
        }

        // GET: Servicios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servicio = await _context.Servicios.SingleOrDefaultAsync(m => m.Id == id);
            if (servicio == null)
            {
                return NotFound();
            }

            return View(servicio);
        }

        // POST: Servicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var servicio = await _context.Servicios.SingleOrDefaultAsync(m => m.Id == id);
            _context.Servicios.Remove(servicio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ServicioExists(long id)
        {
            return _context.Servicios.Any(e => e.Id == id);
        }
    }
}
