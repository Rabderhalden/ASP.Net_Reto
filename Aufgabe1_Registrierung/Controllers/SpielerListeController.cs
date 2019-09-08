using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aufgabe1_Registrierung.Data;
using Aufgabe1_Registrierung.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aufgabe1_Registrierung.Controllers
{
    public class SpielerListeController : Controller
    {

        public IActionResult SeeList()
        {
            return View(SpielerRepo.SpielerListe);
        }
    }
}