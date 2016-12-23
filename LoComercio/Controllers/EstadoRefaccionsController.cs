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
    public class EstadoRefaccionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstadoRefaccionsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: EstadoRefaccions
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadosRefacciones.ToListAsync());
        }

        // GET: EstadoRefaccions/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoRefaccion = await _context.EstadosRefacciones.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoRefaccion == null)
            {
                return NotFound();
            }

            return View(estadoRefaccion);
        }

        // GET: EstadoRefaccions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoRefaccions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] EstadoRefaccion estadoRefaccion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadoRefaccion);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(estadoRefaccion);
        }

        // GET: EstadoRefaccions/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoRefaccion = await _context.EstadosRefacciones.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoRefaccion == null)
            {
                return NotFound();
            }
            return View(estadoRefaccion);
        }

        // POST: EstadoRefaccions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] EstadoRefaccion estadoRefaccion)
        {
            if (id != estadoRefaccion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoRefaccion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoRefaccionExists(estadoRefaccion.Id))
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
            return View(estadoRefaccion);
        }

        // GET: EstadoRefaccions/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoRefaccion = await _context.EstadosRefacciones.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoRefaccion == null)
            {
                return NotFound();
            }

            return View(estadoRefaccion);
        }

        // POST: EstadoRefaccions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var estadoRefaccion = await _context.EstadosRefacciones.SingleOrDefaultAsync(m => m.Id == id);
            _context.EstadosRefacciones.Remove(estadoRefaccion);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool EstadoRefaccionExists(long id)
        {
            return _context.EstadosRefacciones.Any(e => e.Id == id);
        }
    }
}
