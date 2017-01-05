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
    public class EstadoServiciosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstadoServiciosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: EstadoServicios
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadosServicios.ToListAsync());
        }

        // GET: EstadoServicios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoServicio = await _context.EstadosServicios.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoServicio == null)
            {
                return NotFound();
            }

            return View(estadoServicio);
        }

        // GET: EstadoServicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoServicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] EstadoServicio estadoServicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadoServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(estadoServicio);
        }

        // GET: EstadoServicios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoServicio = await _context.EstadosServicios.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoServicio == null)
            {
                return NotFound();
            }
            return View(estadoServicio);
        }

        // POST: EstadoServicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] EstadoServicio estadoServicio)
        {
            if (id != estadoServicio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoServicioExists(estadoServicio.Id))
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
            return View(estadoServicio);
        }

        // GET: EstadoServicios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoServicio = await _context.EstadosServicios.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoServicio == null)
            {
                return NotFound();
            }

            return View(estadoServicio);
        }

        // POST: EstadoServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var estadoServicio = await _context.EstadosServicios.SingleOrDefaultAsync(m => m.Id == id);
            _context.EstadosServicios.Remove(estadoServicio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool EstadoServicioExists(long id)
        {
            return _context.EstadosServicios.Any(e => e.Id == id);
        }
    }
}
