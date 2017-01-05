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
    public class ModelosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ModelosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Modelos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Modelos.Include(m => m.Marca);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Modelos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelo = await _context.Modelos.SingleOrDefaultAsync(m => m.Id == id);
            if (modelo == null)
            {
                return NotFound();
            }

            return View(modelo);
        }

        // GET: Modelos/Create
        public IActionResult Create()
        {
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre");
            return View();
        }

        // POST: Modelos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdMarca,ModeloComercial,Nombre")] Modelo modelo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(modelo);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre", modelo.IdMarca);
            return View(modelo);
        }

        // GET: Modelos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelo = await _context.Modelos.SingleOrDefaultAsync(m => m.Id == id);
            if (modelo == null)
            {
                return NotFound();
            }
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre", modelo.IdMarca);
            return View(modelo);
        }

        // POST: Modelos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,IdMarca,ModeloComercial,Nombre")] Modelo modelo)
        {
            if (id != modelo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(modelo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ModeloExists(modelo.Id))
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
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre", modelo.IdMarca);
            return View(modelo);
        }

        // GET: Modelos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var modelo = await _context.Modelos.SingleOrDefaultAsync(m => m.Id == id);
            if (modelo == null)
            {
                return NotFound();
            }

            return View(modelo);
        }

        // POST: Modelos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var modelo = await _context.Modelos.SingleOrDefaultAsync(m => m.Id == id);
            _context.Modelos.Remove(modelo);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool ModeloExists(long id)
        {
            return _context.Modelos.Any(e => e.Id == id);
        }
    }
}
