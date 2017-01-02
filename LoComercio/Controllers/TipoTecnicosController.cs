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
    public class TipoTecnicosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TipoTecnicosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: TipoTecnicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposTecnico.ToListAsync());
        }

        // GET: TipoTecnicos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTecnico = await _context.TiposTecnico.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoTecnico == null)
            {
                return NotFound();
            }

            return View(tipoTecnico);
        }

        // GET: TipoTecnicos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoTecnicos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] TipoTecnico tipoTecnico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoTecnico);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tipoTecnico);
        }

        // GET: TipoTecnicos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTecnico = await _context.TiposTecnico.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoTecnico == null)
            {
                return NotFound();
            }
            return View(tipoTecnico);
        }

        // POST: TipoTecnicos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] TipoTecnico tipoTecnico)
        {
            if (id != tipoTecnico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoTecnico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoTecnicoExists(tipoTecnico.Id))
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
            return View(tipoTecnico);
        }

        // GET: TipoTecnicos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoTecnico = await _context.TiposTecnico.SingleOrDefaultAsync(m => m.Id == id);
            if (tipoTecnico == null)
            {
                return NotFound();
            }

            return View(tipoTecnico);
        }

        // POST: TipoTecnicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var tipoTecnico = await _context.TiposTecnico.SingleOrDefaultAsync(m => m.Id == id);
            _context.TiposTecnico.Remove(tipoTecnico);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool TipoTecnicoExists(long id)
        {
            return _context.TiposTecnico.Any(e => e.Id == id);
        }
    }
}
