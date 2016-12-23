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
    public class OrdenServiciosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrdenServiciosController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: OrdenServicios
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.OrdenesServicio.Include(o => o.Cliente).Include(o => o.EstadoDispositivo).Include(o => o.EstadoNotificacion).Include(o => o.LugarAlmacenamiento).Include(o => o.Modelo).Include(o => o.Pago).Include(o => o.SolicitudAccesorio).Include(o => o.SolicitudRefaccion).Include(o => o.Tecnico);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: OrdenServicios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenServicio = await _context.OrdenesServicio.SingleOrDefaultAsync(m => m.Id == id);
            if (ordenServicio == null)
            {
                return NotFound();
            }
            
            return View(ordenServicio);
        }
        
        // GET: OrdenServicios/Create
        public IActionResult Create()
        {
            ViewData["IdCliente"] = new SelectList(_context.Clientes.OrderBy(c=>c.Nombre), "Id", "Nombre");
            ViewData["IdEdoDispositivo"] = new SelectList(_context.EstadosDispositivos, "Id", "Nombre");
            ViewData["IdEdoNotificacion"] = new SelectList(_context.EstadosNotificaciones, "Id", "Nombre");
            ViewData["IdLugarAlmacenamiento"] = new SelectList(_context.LugaresAlmacenamiento, "Id", "Nombre");
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloComercial");
            ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre");
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre");
            ViewData["IdPago"] = new SelectList(_context.Pagos, "Id", "Id");
            ViewData["IdSolAccesorio"] = new SelectList(_context.SolicitudAccesorios, "Id", "Id");
            ViewData["IdSolRefaccion"] = new SelectList(_context.SolicitudRefacciones, "Id", "Id");
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre");
            return View();
        }

        // POST: OrdenServicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AceptaRiesgo,ColorDispositivo,ColorPieza,CompanyaOrigen,DejaAccesorios,DesactivoICloud,DescripcionAccesorios,DescripcionFalla,DescripcionRevisionAdicional,EquipoApagado,EquipoMojado,FechaLlegada,FechaPosibleSalida,FechaSalida,IMEI,IdCliente,IdEdoDispositivo,IdEdoNotificacion,IdLugarAlmacenamiento,IdModeloTecnico,IdPago,IdPersonalEntrega,IdSolAccesorio,IdSolRefaccion,IdTecnico,ImplicaRiesgo,NotasReparaciones,Observaciones,PasswordDesbloqueo,PatronDesbloqueo,ReparadoAnteriormente,RevisionAdicional,UsuarioRecibe")] OrdenServicio ordenServicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordenServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Email", ordenServicio.IdCliente);
            ViewData["IdEdoDispositivo"] = new SelectList(_context.EstadosDispositivos, "Id", "Nombre", ordenServicio.IdEdoDispositivo);
            ViewData["IdEdoNotificacion"] = new SelectList(_context.EstadosNotificaciones, "Id", "Nombre", ordenServicio.IdEdoNotificacion);
            ViewData["IdLugarAlmacenamiento"] = new SelectList(_context.LugaresAlmacenamiento, "Id", "Nombre", ordenServicio.IdLugarAlmacenamiento);
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloComercial", ordenServicio.IdModelo);
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre", ordenServicio.IdMarca);
            ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre", ordenServicio.IdTipoServicio);
            ViewData["IdPago"] = new SelectList(_context.Pagos, "Id", "Id", ordenServicio.IdPago);
            ViewData["IdSolAccesorio"] = new SelectList(_context.SolicitudAccesorios, "Id", "Id", ordenServicio.IdSolAccesorio);
            ViewData["IdSolRefaccion"] = new SelectList(_context.SolicitudRefacciones, "Id", "Id", ordenServicio.IdSolRefaccion);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre", ordenServicio.IdTecnico);
            return View(ordenServicio);
        }

        // GET: OrdenServicios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenServicio = await _context.OrdenesServicio.SingleOrDefaultAsync(m => m.Id == id);
            if (ordenServicio == null)
            {
                return NotFound();
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Email", ordenServicio.IdCliente);
            ViewData["IdEdoDispositivo"] = new SelectList(_context.EstadosDispositivos, "Id", "Nombre", ordenServicio.IdEdoDispositivo);
            ViewData["IdEdoNotificacion"] = new SelectList(_context.EstadosNotificaciones, "Id", "Nombre", ordenServicio.IdEdoNotificacion);
            ViewData["IdLugarAlmacenamiento"] = new SelectList(_context.LugaresAlmacenamiento, "Id", "Nombre", ordenServicio.IdLugarAlmacenamiento);
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloComercial", ordenServicio.IdModelo);
            ViewData["IdPago"] = new SelectList(_context.Pagos, "Id", "Id", ordenServicio.IdPago);
            ViewData["IdSolAccesorio"] = new SelectList(_context.SolicitudAccesorios, "Id", "Id", ordenServicio.IdSolAccesorio);
            ViewData["IdSolRefaccion"] = new SelectList(_context.SolicitudRefacciones, "Id", "Id", ordenServicio.IdSolRefaccion);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre", ordenServicio.IdTecnico);
            return View(ordenServicio);
        }

        // POST: OrdenServicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,AceptaRiesgo,ColorDispositivo,ColorPieza,CompanyaOrigen,DejaAccesorios,DesactivoICloud,DescripcionAccesorios,DescripcionFalla,DescripcionRevisionAdicional,EquipoApagado,EquipoMojado,FechaLlegada,FechaPosibleSalida,FechaSalida,IMEI,IdCliente,IdEdoDispositivo,IdEdoNotificacion,IdLugarAlmacenamiento,IdModeloTecnico,IdPago,IdPersonalEntrega,IdSolAccesorio,IdSolRefaccion,IdTecnico,ImplicaRiesgo,NotasReparaciones,Observaciones,PasswordDesbloqueo,PatronDesbloqueo,ReparadoAnteriormente,RevisionAdicional,UsuarioRecibe")] OrdenServicio ordenServicio)
        {
            if (id != ordenServicio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordenServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenServicioExists(ordenServicio.Id))
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
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Email", ordenServicio.IdCliente);
            ViewData["IdEdoDispositivo"] = new SelectList(_context.EstadosDispositivos, "Id", "Nombre", ordenServicio.IdEdoDispositivo);
            ViewData["IdEdoNotificacion"] = new SelectList(_context.EstadosNotificaciones, "Id", "Nombre", ordenServicio.IdEdoNotificacion);
            ViewData["IdLugarAlmacenamiento"] = new SelectList(_context.LugaresAlmacenamiento, "Id", "Nombre", ordenServicio.IdLugarAlmacenamiento);
            ViewData["IdModeloTecnico"] = new SelectList(_context.Modelos, "Id", "ModeloComercial", ordenServicio.IdModelo);
            ViewData["IdPago"] = new SelectList(_context.Pagos, "Id", "Id", ordenServicio.IdPago);
            ViewData["IdSolAccesorio"] = new SelectList(_context.SolicitudAccesorios, "Id", "Id", ordenServicio.IdSolAccesorio);
            ViewData["IdSolRefaccion"] = new SelectList(_context.SolicitudRefacciones, "Id", "Id", ordenServicio.IdSolRefaccion);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre", ordenServicio.IdTecnico);
            return View(ordenServicio);
        }

        // GET: OrdenServicios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenServicio = await _context.OrdenesServicio.SingleOrDefaultAsync(m => m.Id == id);
            if (ordenServicio == null)
            {
                return NotFound();
            }

            return View(ordenServicio);
        }

        // POST: OrdenServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var ordenServicio = await _context.OrdenesServicio.SingleOrDefaultAsync(m => m.Id == id);
            _context.OrdenesServicio.Remove(ordenServicio);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool OrdenServicioExists(long id)
        {
            return _context.OrdenesServicio.Any(e => e.Id == id);
        }
    }
}
