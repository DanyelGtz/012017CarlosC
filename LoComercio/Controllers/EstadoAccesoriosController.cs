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
    public class EstadoAccesoriosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstadoAccesoriosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: EstadoAccesorios
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadosAccesorios.ToListAsync());
        }

        // GET: EstadoAccesorios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoAccesorio = await _context.EstadosAccesorios.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoAccesorio == null)
            {
                return NotFound();
            }

            return View(estadoAccesorio);
        }

        // GET: EstadoAccesorios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoAccesorios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] EstadoAccesorio estadoAccesorio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadoAccesorio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(estadoAccesorio);
        }

        // GET: EstadoAccesorios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoAccesorio = await _context.EstadosAccesorios.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoAccesorio == null)
            {
                return NotFound();
            }
            return View(estadoAccesorio);
        }

        // POST: EstadoAccesorios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] EstadoAccesorio estadoAccesorio)
        {
            if (id != estadoAccesorio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoAccesorio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoAccesorioExists(estadoAccesorio.Id))
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
            return View(estadoAccesorio);
        }

        // GET: EstadoAccesorios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoAccesorio = await _context.EstadosAccesorios.SingleOrDefaultAsync(m => m.Id == id);
            if (estadoAccesorio == null)
            {
                return NotFound();
            }

            return View(estadoAccesorio);
        }

        // POST: EstadoAccesorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var estadoAccesorio = await _context.EstadosAccesorios.SingleOrDefaultAsync(m => m.Id == id);
            _context.EstadosAccesorios.Remove(estadoAccesorio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool EstadoAccesorioExists(long id)
        {
            return _context.EstadosAccesorios.Any(e => e.Id == id);
        }
    }
}
