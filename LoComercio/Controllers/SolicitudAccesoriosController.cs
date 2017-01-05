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
    public class SolicitudAccesoriosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SolicitudAccesoriosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: SolicitudAccesorios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SolicitudAccesorios.Include(s => s.Accesorio).Include(s => s.EstadoAccesorio);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SolicitudAccesorios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudAccesorio = await _context.SolicitudAccesorios.SingleOrDefaultAsync(m => m.Id == id);
            if (solicitudAccesorio == null)
            {
                return NotFound();
            }

            return View(solicitudAccesorio);
        }

        // GET: SolicitudAccesorios/Create
        public IActionResult Create()
        {
            ViewData["IdAccesorio"] = new SelectList(_context.Accesorios, "Id", "Nombre");
            ViewData["IdEdoAccesorio"] = new SelectList(_context.EstadosAccesorios, "Id", "Nombre");
            return View();
        }

        // POST: SolicitudAccesorios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Cantidad,Fecha,IdAccesorio,IdEdoAccesorio,IdUsuario")] SolicitudAccesorio solicitudAccesorio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(solicitudAccesorio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdAccesorio"] = new SelectList(_context.Accesorios, "Id", "Nombre", solicitudAccesorio.IdAccesorio);
            ViewData["IdEdoAccesorio"] = new SelectList(_context.EstadosAccesorios, "Id", "Nombre", solicitudAccesorio.IdEdoAccesorio);
            return View(solicitudAccesorio);
        }

        // GET: SolicitudAccesorios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudAccesorio = await _context.SolicitudAccesorios.SingleOrDefaultAsync(m => m.Id == id);
            if (solicitudAccesorio == null)
            {
                return NotFound();
            }
            ViewData["IdAccesorio"] = new SelectList(_context.Accesorios, "Id", "Nombre", solicitudAccesorio.IdAccesorio);
            ViewData["IdEdoAccesorio"] = new SelectList(_context.EstadosAccesorios, "Id", "Nombre", solicitudAccesorio.IdEdoAccesorio);
            return View(solicitudAccesorio);
        }

        // POST: SolicitudAccesorios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Cantidad,Fecha,IdAccesorio,IdEdoAccesorio,IdUsuario")] SolicitudAccesorio solicitudAccesorio)
        {
            if (id != solicitudAccesorio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(solicitudAccesorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SolicitudAccesorioExists(solicitudAccesorio.Id))
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
            ViewData["IdAccesorio"] = new SelectList(_context.Accesorios, "Id", "Nombre", solicitudAccesorio.IdAccesorio);
            ViewData["IdEdoAccesorio"] = new SelectList(_context.EstadosAccesorios, "Id", "Nombre", solicitudAccesorio.IdEdoAccesorio);
            return View(solicitudAccesorio);
        }

        // GET: SolicitudAccesorios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var solicitudAccesorio = await _context.SolicitudAccesorios.SingleOrDefaultAsync(m => m.Id == id);
            if (solicitudAccesorio == null)
            {
                return NotFound();
            }

            return View(solicitudAccesorio);
        }

        // POST: SolicitudAccesorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var solicitudAccesorio = await _context.SolicitudAccesorios.SingleOrDefaultAsync(m => m.Id == id);
            _context.SolicitudAccesorios.Remove(solicitudAccesorio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool SolicitudAccesorioExists(long id)
        {
            return _context.SolicitudAccesorios.Any(e => e.Id == id);
        }
    }
}
