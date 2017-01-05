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
    public class AccesoriosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccesoriosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Accesorios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accesorios.ToListAsync());
        }

        // GET: Accesorios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accesorio = await _context.Accesorios.SingleOrDefaultAsync(m => m.Id == id);
            if (accesorio == null)
            {
                return NotFound();
            }

            return View(accesorio);
        }

        // GET: Accesorios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accesorios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CantMax,CantMin,Existencia,Nombre")] Accesorio accesorio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accesorio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(accesorio);
        }

        // GET: Accesorios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accesorio = await _context.Accesorios.SingleOrDefaultAsync(m => m.Id == id);
            if (accesorio == null)
            {
                return NotFound();
            }
            return View(accesorio);
        }

        // POST: Accesorios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,CantMax,CantMin,Existencia,Nombre")] Accesorio accesorio)
        {
            if (id != accesorio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accesorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccesorioExists(accesorio.Id))
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
            return View(accesorio);
        }

        // GET: Accesorios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accesorio = await _context.Accesorios.SingleOrDefaultAsync(m => m.Id == id);
            if (accesorio == null)
            {
                return NotFound();
            }

            return View(accesorio);
        }

        // POST: Accesorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var accesorio = await _context.Accesorios.SingleOrDefaultAsync(m => m.Id == id);
            _context.Accesorios.Remove(accesorio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool AccesorioExists(long id)
        {
            return _context.Accesorios.Any(e => e.Id == id);
        }
    }
}
