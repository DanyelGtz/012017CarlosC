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
    public class TipoNotificacionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoNotificacionsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: TipoNotificacions
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposNotificaciones.ToListAsync());
        }

        // GET: TipoNotificacions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoNotificacion = await _context.TiposNotificaciones.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoNotificacion == null)
            {
                return NotFound();
            }

            return View(tipoNotificacion);
        }

        // GET: TipoNotificacions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoNotificacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoNotificacion tipoNotificacion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoNotificacion);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tipoNotificacion);
        }

        // GET: TipoNotificacions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoNotificacion = await _context.TiposNotificaciones.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoNotificacion == null)
            {
                return NotFound();
            }
            return View(tipoNotificacion);
        }

        // POST: TipoNotificacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] TipoNotificacion tipoNotificacion)
        {
            if (id != tipoNotificacion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoNotificacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoNotificacionExists(tipoNotificacion.Id))
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
            return View(tipoNotificacion);
        }

        // GET: TipoNotificacions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoNotificacion = await _context.TiposNotificaciones.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoNotificacion == null)
            {
                return NotFound();
            }

            return View(tipoNotificacion);
        }

        // POST: TipoNotificacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var tipoNotificacion = await _context.TiposNotificaciones.SingleOrDefaultAsync(m => m.Id == id);
            _context.TiposNotificaciones.Remove(tipoNotificacion);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TipoNotificacionExists(long id)
        {
            return _context.TiposNotificaciones.Any(e => e.Id == id);
        }
    }
}
