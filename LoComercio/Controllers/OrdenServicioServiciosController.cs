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
    public class OrdenServicioServiciosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdenServicioServiciosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: OrdenServicioServicios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OrdenesServicioServicio.Include(o => o.EstadoServicio).Include(o => o.OrdenServicio).Include(o => o.Servicio).Include(t=>t.Tecnico);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OrdenServicioServicios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenServicioServicio = await _context.OrdenesServicioServicio.Include(os=>os.EstadoServicio).Include(os=>os.Servicio).Include(os=>os.Tecnico).SingleOrDefaultAsync(m => m.Id == id);
            if (ordenServicioServicio == null)
            {
                return NotFound();
            }

            return View(ordenServicioServicio);
        }
        [HttpPost]
        public IActionResult Details(long id)
        {
            var ordenServicioServicio = _context.OrdenesServicioServicio.SingleOrDefault(os => os.Id == id);
            
            return RedirectToAction("Edit", "OrdenServicios", new { @id = ordenServicioServicio.IdOrdenServicio });

        }

        // GET: OrdenServicioServicios/Create
        public IActionResult Create()
        {
            ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre");
            ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre");
            OrdenServicioServicio os = new OrdenServicioServicio();
                //os.IdOrdenServicio = long.Parse(Request.["IdOrdenServicio"]);
                ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre");
                ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre");
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre");
            return View();
        }

        // POST: OrdenServicioServicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEdoServicio,IdOrdenServicio,IdServicio,IdTecnico,PrecioServicio,Observaciones")] OrdenServicioServicio ordenServicioServicio, long id)
        {
            if (ModelState.IsValid)
            {

                _context.Add(ordenServicioServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", "OrdenServicios", new { @id=ordenServicioServicio.IdOrdenServicio });
            }
            else
            {
                ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre", ordenServicioServicio.IdEdoServicio);
                ViewData["IdOrdenServicio"] = new SelectList(_context.OrdenesServicio, "Id", "Id", ordenServicioServicio.IdOrdenServicio);
                ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre", ordenServicioServicio.IdServicio);
                ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre");
                ordenServicioServicio.IdOrdenServicio = id;
                return View(ordenServicioServicio);
            }
        }

        // GET: OrdenServicioServicios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenServicioServicio = await _context.OrdenesServicioServicio.SingleOrDefaultAsync(m => m.Id == id);
            if (ordenServicioServicio == null)
            {
                return NotFound();
            }
            ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre", ordenServicioServicio.IdEdoServicio);
            ViewData["IdOrdenServicio"] = new SelectList(_context.OrdenesServicio, "Id", "Id", ordenServicioServicio.IdOrdenServicio);
            ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre", ordenServicioServicio.IdServicio);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre");
            return View(ordenServicioServicio);
        }

        // POST: OrdenServicioServicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,IdEdoServicio,IdOrdenServicio,IdServicio,PrecioServicio,IdTecnico,Observaciones")] OrdenServicioServicio ordenServicioServicio)
        {
            if (id != ordenServicioServicio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordenServicioServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenServicioServicioExists(ordenServicioServicio.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Edit", "OrdenServicios", new { @id = ordenServicioServicio.IdOrdenServicio });
            }
            ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre", ordenServicioServicio.IdEdoServicio);
            ViewData["IdOrdenServicio"] = new SelectList(_context.OrdenesServicio, "Id", "Id", ordenServicioServicio.IdOrdenServicio);
            ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre", ordenServicioServicio.IdServicio);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre");
            return View(ordenServicioServicio);
        }

        // GET: OrdenServicioServicios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenServicioServicio = await _context.OrdenesServicioServicio.SingleOrDefaultAsync(m => m.Id == id);
            if (ordenServicioServicio == null)
            {
                return NotFound();
            }

            return View(ordenServicioServicio);
        }

        // POST: OrdenServicioServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var ordenServicioServicio = await _context.OrdenesServicioServicio.SingleOrDefaultAsync(m => m.Id == id);
            _context.OrdenesServicioServicio.Remove(ordenServicioServicio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit", "OrdenServicios", new { @id = ordenServicioServicio.IdOrdenServicio });
        }

        private bool OrdenServicioServicioExists(long id)
        {
            return _context.OrdenesServicioServicio.Any(e => e.Id == id);
        }
    }
}
