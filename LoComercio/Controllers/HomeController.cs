using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoDesbloqueo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.IsInRole("Administrador"))
            {
                return RedirectToAction("Index", "Manage");
            }
            if (User.IsInRole("Tecnico") || (User.IsInRole("AtencionCliente")) || (User.IsInRole("Supervisor")))
            {
                return RedirectToAction("Index", "OrdenServicios");
            }
            if (User.IsInRole("Usuario"))
            {
                return View();
            }
            else
            {
                return View();
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
