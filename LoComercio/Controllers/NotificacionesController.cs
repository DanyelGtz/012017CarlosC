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
    public class NotificacionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NotificacionesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Notificaciones
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Notificaciones.Include(n => n.OrdenServicio).Include(n => n.TipoNotificacion);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Notificaciones/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notificacion = await _context.Notificaciones.SingleOrDefaultAsync(m => m.Id == id);
            if (notificacion == null)
            {
                return NotFound();
            }

            return View(notificacion);
        }

        // GET: Notificaciones/Create
        public IActionResult Create()
        {
            ViewData["IdOrdenServicio"] = new SelectList(_context.OrdenesServicio, "Id", "CompanyaOrigen");
            ViewData["IdTipoNotificacion"] = new SelectList(_context.TiposNotificaciones, "Id", "Nombre");
            return View();
        }

        // POST: Notificaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha,IdOrdenServicio,IdTipoNotificacion,NotificacionActiva")] Notificacion notificacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notificacion);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdOrdenServicio"] = new SelectList(_context.OrdenesServicio, "Id", "CompanyaOrigen", notificacion.IdOrdenServicio);
            ViewData["IdTipoNotificacion"] = new SelectList(_context.TiposNotificaciones, "Id", "Nombre", notificacion.IdTipoNotificacion);
            return View(notificacion);
        }

        // GET: Notificaciones/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notificacion = await _context.Notificaciones.SingleOrDefaultAsync(m => m.Id == id);
            if (notificacion == null)
            {
                return NotFound();
            }
            ViewData["IdOrdenServicio"] = new SelectList(_context.OrdenesServicio, "Id", "CompanyaOrigen", notificacion.IdOrdenServicio);
            ViewData["IdTipoNotificacion"] = new SelectList(_context.TiposNotificaciones, "Id", "Nombre", notificacion.IdTipoNotificacion);
            return View(notificacion);
        }

        // POST: Notificaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Fecha,IdOrdenServicio,IdTipoNotificacion,NotificacionActiva")] Notificacion notificacion)
        {
            if (id != notificacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notificacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotificacionExists(notificacion.Id))
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
            ViewData["IdOrdenServicio"] = new SelectList(_context.OrdenesServicio, "Id", "CompanyaOrigen", notificacion.IdOrdenServicio);
            ViewData["IdTipoNotificacion"] = new SelectList(_context.TiposNotificaciones, "Id", "Nombre", notificacion.IdTipoNotificacion);
            return View(notificacion);
        }

        // GET: Notificaciones/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notificacion = await _context.Notificaciones.SingleOrDefaultAsync(m => m.Id == id);
            if (notificacion == null)
            {
                return NotFound();
            }

            return View(notificacion);
        }

        // POST: Notificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var notificacion = await _context.Notificaciones.SingleOrDefaultAsync(m => m.Id == id);
            _context.Notificaciones.Remove(notificacion);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool NotificacionExists(long id)
        {
            return _context.Notificaciones.Any(e => e.Id == id);
        }
    }
}
