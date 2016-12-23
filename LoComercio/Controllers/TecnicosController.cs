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
    public class TecnicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TecnicosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Tecnicos
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Tecnicos.Include(t => t.TipoTecnico);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Tecnicos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnico = await _context.Tecnicos.SingleOrDefaultAsync(m => m.Id == id);
            if (tecnico == null)
            {
                return NotFound();
            }

            return View(tecnico);
        }

        // GET: Tecnicos/Create
        public IActionResult Create()
        {
            ViewData["IdTipoTecnico"] = new SelectList(_context.TiposTecnico, "Id", "Nombre");
            return View();
        }

        // POST: Tecnicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdTipoTecnico,Nombre")] Tecnico tecnico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tecnico);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdTipoTecnico"] = new SelectList(_context.TiposTecnico, "Id", "Nombre", tecnico.IdTipoTecnico);
            return View(tecnico);
        }

        // GET: Tecnicos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnico = await _context.Tecnicos.SingleOrDefaultAsync(m => m.Id == id);
            if (tecnico == null)
            {
                return NotFound();
            }
            ViewData["IdTipoTecnico"] = new SelectList(_context.TiposTecnico, "Id", "Nombre", tecnico.IdTipoTecnico);
            return View(tecnico);
        }

        // POST: Tecnicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,IdTipoTecnico,Nombre")] Tecnico tecnico)
        {
            if (id != tecnico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tecnico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TecnicoExists(tecnico.Id))
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
            ViewData["IdTipoTecnico"] = new SelectList(_context.TiposTecnico, "Id", "Nombre", tecnico.IdTipoTecnico);
            return View(tecnico);
        }

        // GET: Tecnicos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tecnico = await _context.Tecnicos.SingleOrDefaultAsync(m => m.Id == id);
            if (tecnico == null)
            {
                return NotFound();
            }

            return View(tecnico);
        }

        // POST: Tecnicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var tecnico = await _context.Tecnicos.SingleOrDefaultAsync(m => m.Id == id);
            _context.Tecnicos.Remove(tecnico);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TecnicoExists(long id)
        {
            return _context.Tecnicos.Any(e => e.Id == id);
        }
    }
}
