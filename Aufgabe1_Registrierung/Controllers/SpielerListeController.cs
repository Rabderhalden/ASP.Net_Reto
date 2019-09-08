using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aufgabe1_Registrierung.Controllers
{
    public class SpielerListeController : Controller
    {
        public IActionResult SeeList()
        {
            return View();
        }
    }
}