using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LoDesbloqueo.Models.OrdenServicioViewModels;
using LoDesbloqueo.Data;

namespace LoDesbloqueo.Controllers
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
            var applicationDbContext = _context.OrdenesServicio.Include(o => o.Cliente).Include(o => o.EstadoDispositivo).Include(o => o.LugarAlmacenamiento).Include(o => o.Pago).Include(o => o.SolicitudAccesorio).Include(o => o.SolicitudRefaccion).Include(o=>o.TipoServicio).Include(o=>o.Modelo);
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
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico");
            ViewData["IdEmpresaTelefonica"] = new SelectList(_context.EmpresasTelefonicas, "Id", "Nombre");
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
        public async Task<IActionResult> Create([Bind("Id,AceptaRiesgo,ColorDispositivo,ColorPieza,CompanyaOrigen,DejaAccesorios,DesactivoICloud,DescripcionAccesorios,DescripcionFalla,DescripcionRevisionAdicional,EquipoApagado,EquipoMojado,FechaLlegada,FechaPosibleSalida,FechaSalida,IMEI,IdCliente,IdEdoDispositivo,IdEdoNotificacion,IdLugarAlmacenamiento,IdModelo,IdMarca,IdPago,IdPersonalEntrega,IdSolAccesorio,IdSolRefaccion,IdTecnico,IdTipoServicio,ImplicaRiesgo,NotasReparaciones,Observaciones,PasswordDesbloqueo,PatronDesbloqueo,ReparadoAnteriormente,RevisionAdicional,UsuarioRecibe")] OrdenServicio ordenServicio)
        {
            ordenServicio.FechaLlegada = System.DateTime.Now;
            if (ModelState.IsValid)
            {
                _context.Add(ordenServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Email", ordenServicio.IdCliente);
            ViewData["IdEmpresaTelefonica"] = new SelectList(_context.EmpresasTelefonicas, "Id", "Nombre");
            ViewData["IdEdoDispositivo"] = new SelectList(_context.EstadosDispositivos, "Id", "Nombre", ordenServicio.IdEdoDispositivo);
            ViewData["IdLugarAlmacenamiento"] = new SelectList(_context.LugaresAlmacenamiento, "Id", "Nombre", ordenServicio.IdLugarAlmacenamiento);
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico", ordenServicio.IdModelo);
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre", ordenServicio.IdMarca);
            ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre", ordenServicio.IdTipoServicio);
            ViewData["IdPago"] = new SelectList(_context.Pagos, "Id", "Id", ordenServicio.IdPago);
            ViewData["IdSolAccesorio"] = new SelectList(_context.SolicitudAccesorios, "Id", "Id", ordenServicio.IdSolAccesorio);
            ViewData["IdSolRefaccion"] = new SelectList(_context.SolicitudRefacciones, "Id", "Id", ordenServicio.IdSolRefaccion);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre");
            return View(ordenServicio);
        }

        // GET: OrdenServicios/Edit/5
        [HttpGet]
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
            ViewData["IdEmpresaTelefonica"] = new SelectList(_context.EmpresasTelefonicas, "Id", "Nombre");
            ViewData["IdLugarAlmacenamiento"] = new SelectList(_context.LugaresAlmacenamiento, "Id", "Nombre", ordenServicio.IdLugarAlmacenamiento);
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico", ordenServicio.IdModelo);
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre", ordenServicio.IdMarca);
            ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre");
            ViewData["IdPago"] = new SelectList(_context.Pagos, "Id", "Id", ordenServicio.IdPago);
            ViewData["IdSolAccesorio"] = new SelectList(_context.SolicitudAccesorios, "Id", "Id", ordenServicio.IdSolAccesorio);
            ViewData["IdSolRefaccion"] = new SelectList(_context.SolicitudRefacciones, "Id", "Id", ordenServicio.IdSolRefaccion);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre");

            OrdenServicioViewModel osVm = new OrdenServicioViewModel();
            osVm.OrdenServicio = ordenServicio;
            osVm.OrdenServicioServicios = _context.OrdenesServicioServicio.Include(o => o.EstadoServicio).Include(o => o.OrdenServicio).Include(o=>o.Tecnico).Where(os=>os.IdOrdenServicio==id).ToList();
            ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre");
            ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre");

            return View(osVm);
        }

        // POST: OrdenServicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,AceptaRiesgo,ColorDispositivo,ColorPieza,CompanyaOrigen,DejaAccesorios,DesactivoICloud,DescripcionAccesorios,DescripcionFalla,DescripcionRevisionAdicional,EquipoApagado,EquipoMojado,FechaLlegada,FechaPosibleSalida,FechaSalida,IMEI,IdCliente,IdEdoDispositivo,IdEdoNotificacion,IdLugarAlmacenamiento,IdModelo,IdMarca,IdPago,IdPersonalEntrega,IdSolAccesorio,IdSolRefaccion,IdTecnico,IdTipoServicio,ImplicaRiesgo,NotasReparaciones,Observaciones,PasswordDesbloqueo,PatronDesbloqueo,ReparadoAnteriormente,RevisionAdicional,UsuarioRecibe")] OrdenServicio ordenServicio)
        {
            var OrdenS = _context.OrdenesServicio.SingleOrDefault(o => o.Id == id);
            if (id != OrdenS.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                OrdenServicio os = _context.OrdenesServicio.SingleOrDefault(o => o.Id == id);
                try
                {
                    
                    os.AceptaRiesgo = ordenServicio.AceptaRiesgo;
                    os.ImplicaRiesgo = ordenServicio.ImplicaRiesgo;
                    os.ColorPieza = ordenServicio.ColorPieza;
                    os.IdModelo = ordenServicio.IdModelo;
                    os.IdEdoDispositivo = ordenServicio.IdEdoDispositivo;
                    os.IdTipoServicio = ordenServicio.IdTipoServicio;
                    os.IdLugarAlmacenamiento = ordenServicio.IdLugarAlmacenamiento;
                    os.FechaPosibleSalida = ordenServicio.FechaPosibleSalida;
                    os.Observaciones = ordenServicio.Observaciones;
                    os.UsuarioRecibe = ordenServicio.UsuarioRecibe;
                    _context.Update(os);
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
               
                OrdenServicioViewModel osVm = new OrdenServicioViewModel();
                osVm.OrdenServicio = os;
                osVm.OrdenServicioServicios = _context.OrdenesServicioServicio.Include(o => o.EstadoServicio).Include(o => o.OrdenServicio).Include(o=>o.Tecnico).ToList();
                ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre");
                ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre");
                ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Email", ordenServicio.IdCliente);
                ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre");
                ViewData["IdEmpresaTelefonica"] = new SelectList(_context.EmpresasTelefonicas, "Id", "Nombre");
                ViewData["IdEdoDispositivo"] = new SelectList(_context.EstadosDispositivos, "Id", "Nombre", ordenServicio.IdEdoDispositivo);
                ViewData["IdLugarAlmacenamiento"] = new SelectList(_context.LugaresAlmacenamiento, "Id", "Nombre", ordenServicio.IdLugarAlmacenamiento);
                ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico", ordenServicio.IdModelo);
                ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre", ordenServicio.IdMarca);
                ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre");
                ViewData["IdPago"] = new SelectList(_context.Pagos, "Id", "Id", ordenServicio.IdPago);
                ViewData["IdSolAccesorio"] = new SelectList(_context.SolicitudAccesorios, "Id", "Id", ordenServicio.IdSolAccesorio);
                ViewData["IdSolRefaccion"] = new SelectList(_context.SolicitudRefacciones, "Id", "Id", ordenServicio.IdSolRefaccion);
                return View(osVm);
            }
            ViewData["IdEdoServicio"] = new SelectList(_context.EstadosServicios, "Id", "Nombre");
            ViewData["IdServicio"] = new SelectList(_context.Servicios, "Id", "Nombre");
            ViewData["IdCliente"] = new SelectList(_context.Clientes, "Id", "Email", ordenServicio.IdCliente);
            ViewData["IdEdoDispositivo"] = new SelectList(_context.EstadosDispositivos, "Id", "Nombre", ordenServicio.IdEdoDispositivo);
            ViewData["IdLugarAlmacenamiento"] = new SelectList(_context.LugaresAlmacenamiento, "Id", "Nombre", ordenServicio.IdLugarAlmacenamiento);
            ViewData["IdModelo"] = new SelectList(_context.Modelos, "Id", "ModeloTecnico", ordenServicio.IdModelo);
            ViewData["IdMarca"] = new SelectList(_context.Marcas, "Id", "Nombre", ordenServicio.IdMarca);
            ViewData["IdTipoServicio"] = new SelectList(_context.TiposServicio, "Id", "Nombre");
            ViewData["IdPago"] = new SelectList(_context.Pagos, "Id", "Id", ordenServicio.IdPago);
            ViewData["IdSolAccesorio"] = new SelectList(_context.SolicitudAccesorios, "Id", "Id", ordenServicio.IdSolAccesorio);
            ViewData["IdSolRefaccion"] = new SelectList(_context.SolicitudRefacciones, "Id", "Id", ordenServicio.IdSolRefaccion);
            ViewData["IdTecnico"] = new SelectList(_context.Tecnicos, "Id", "Nombre");
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
