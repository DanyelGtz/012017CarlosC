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
    public class EstadoDispositivosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstadoDispositivosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: EstadoDispositivoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadosDispositivos.ToListAsync());
        }

        // GET: EstadoDispositivoes/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoDispositivo = await _context.EstadosDispositivos.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoDispositivo == null)
            {
                return NotFound();
            }

            return View(estadoDispositivo);
        }

        // GET: EstadoDispositivoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoDispositivoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] EstadoDispositivo estadoDispositivo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadoDispositivo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(estadoDispositivo);
        }

        // GET: EstadoDispositivoes/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoDispositivo = await _context.EstadosDispositivos.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoDispositivo == null)
            {
                return NotFound();
            }
            return View(estadoDispositivo);
        }

        // POST: EstadoDispositivoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] EstadoDispositivo estadoDispositivo)
        {
            if (id != estadoDispositivo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoDispositivo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoDispositivoExists(estadoDispositivo.Id))
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
            return View(estadoDispositivo);
        }

        // GET: EstadoDispositivoes/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoDispositivo = await _context.EstadosDispositivos.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoDispositivo == null)
            {
                return NotFound();
            }

            return View(estadoDispositivo);
        }

        // POST: EstadoDispositivoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var estadoDispositivo = await _context.EstadosDispositivos.SingleOrDefaultAsync(m => m.Id == id);
            _context.EstadosDispositivos.Remove(estadoDispositivo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool EstadoDispositivoExists(long id)
        {
            return _context.EstadosDispositivos.Any(e => e.Id == id);
        }
    }
}
