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
    public class LugarAlmacenamientosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LugarAlmacenamientosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: LugarAlmacenamientos
        public async Task<IActionResult> Index()
        {
            return View(await _context.LugaresAlmacenamiento.ToListAsync());
        }

        // GET: LugarAlmacenamientos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lugarAlmacenamiento = await _context.LugaresAlmacenamiento.SingleOrDefaultAsync(m => m.Id == id);
            if (lugarAlmacenamiento == null)
            {
                return NotFound();
            }

            return View(lugarAlmacenamiento);
        }

        // GET: LugarAlmacenamientos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LugarAlmacenamientos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] LugarAlmacenamiento lugarAlmacenamiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lugarAlmacenamiento);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(lugarAlmacenamiento);
        }

        // GET: LugarAlmacenamientos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lugarAlmacenamiento = await _context.LugaresAlmacenamiento.SingleOrDefaultAsync(m => m.Id == id);
            if (lugarAlmacenamiento == null)
            {
                return NotFound();
            }
            return View(lugarAlmacenamiento);
        }

        // POST: LugarAlmacenamientos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] LugarAlmacenamiento lugarAlmacenamiento)
        {
            if (id != lugarAlmacenamiento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lugarAlmacenamiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LugarAlmacenamientoExists(lugarAlmacenamiento.Id))
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
            return View(lugarAlmacenamiento);
        }

        // GET: LugarAlmacenamientos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lugarAlmacenamiento = await _context.LugaresAlmacenamiento.SingleOrDefaultAsync(m => m.Id == id);
            if (lugarAlmacenamiento == null)
            {
                return NotFound();
            }

            return View(lugarAlmacenamiento);
        }

        // POST: LugarAlmacenamientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var lugarAlmacenamiento = await _context.LugaresAlmacenamiento.SingleOrDefaultAsync(m => m.Id == id);
            _context.LugaresAlmacenamiento.Remove(lugarAlmacenamiento);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool LugarAlmacenamientoExists(long id)
        {
            return _context.LugaresAlmacenamiento.Any(e => e.Id == id);
        }
    }
}
