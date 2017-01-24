using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoDesbloqueo.Data;

namespace LoComercio.Controllers
{
    public class EmpresaTelefonicasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmpresaTelefonicasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: EmpresaTelefonicas
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmpresasTelefonicas.ToListAsync());
        }

        // GET: EmpresaTelefonicas/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresaTelefonica = await _context.EmpresasTelefonicas.SingleOrDefaultAsync(m => m.Id == id);
            if (empresaTelefonica == null)
            {
                return NotFound();
            }

            return View(empresaTelefonica);
        }

        // GET: EmpresaTelefonicas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmpresaTelefonicas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] EmpresaTelefonica empresaTelefonica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empresaTelefonica);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(empresaTelefonica);
        }

        // GET: EmpresaTelefonicas/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresaTelefonica = await _context.EmpresasTelefonicas.SingleOrDefaultAsync(m => m.Id == id);
            if (empresaTelefonica == null)
            {
                return NotFound();
            }
            return View(empresaTelefonica);
        }

        // POST: EmpresaTelefonicas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nombre")] EmpresaTelefonica empresaTelefonica)
        {
            if (id != empresaTelefonica.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(empresaTelefonica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmpresaTelefonicaExists(empresaTelefonica.Id))
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
            return View(empresaTelefonica);
        }

        // GET: EmpresaTelefonicas/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empresaTelefonica = await _context.EmpresasTelefonicas.SingleOrDefaultAsync(m => m.Id == id);
            if (empresaTelefonica == null)
            {
                return NotFound();
            }

            return View(empresaTelefonica);
        }

        // POST: EmpresaTelefonicas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var empresaTelefonica = await _context.EmpresasTelefonicas.SingleOrDefaultAsync(m => m.Id == id);
            _context.EmpresasTelefonicas.Remove(empresaTelefonica);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool EmpresaTelefonicaExists(long id)
        {
            return _context.EmpresasTelefonicas.Any(e => e.Id == id);
        }
    }
}
