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
    public class EstadoNotificacionesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstadoNotificacionesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: EstadoNotificacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadosNotificaciones.ToListAsync());
        }

        // GET: EstadoNotificacions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoNotificacion = await _context.EstadosNotificaciones.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoNotificacion == null)
            {
                return NotFound();
            }

            return View(estadoNotificacion);
        }

        // GET: EstadoNotificacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoNotificacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] EstadoNotificacion estadoNotificacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadoNotificacion);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(estadoNotificacion);
        }

        // GET: EstadoNotificacions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoNotificacion = await _context.EstadosNotificaciones.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoNotificacion == null)
            {
                return NotFound();
            }
            return View(estadoNotificacion);
        }

        // POST: EstadoNotificacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] EstadoNotificacion estadoNotificacion)
        {
            if (id != estadoNotificacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoNotificacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoNotificacionExists(estadoNotificacion.Id))
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
            return View(estadoNotificacion);
        }

        // GET: EstadoNotificacions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoNotificacion = await _context.EstadosNotificaciones.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoNotificacion == null)
            {
                return NotFound();
            }

            return View(estadoNotificacion);
        }

        // POST: EstadoNotificacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var estadoNotificacion = await _context.EstadosNotificaciones.SingleOrDefaultAsync(m => m.Id == id);
            _context.EstadosNotificaciones.Remove(estadoNotificacion);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool EstadoNotificacionExists(long id)
        {
            return _context.EstadosNotificaciones.Any(e => e.Id == id);
        }
    }
}
