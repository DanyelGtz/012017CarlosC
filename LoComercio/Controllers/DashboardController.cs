using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LoDesbloqueo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            if(User.IsInRole("Administrador"))
            {
                return RedirectToAction("Index", "Manage");
            }

            return View();
        }
    }
}