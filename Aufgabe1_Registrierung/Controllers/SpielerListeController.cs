using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aufgabe1_Registrierung.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aufgabe1_Registrierung.Controllers
{
    public class SpielerListeController : Controller
    {
        private static IEnumerable<Spieler> spielers;

        static void CreateList()
        {
            spielers = new List<Spieler>();
        }

        public void RegisterSpieler(Spieler spieler)
        {
            //spielers.add
        }

        public IActionResult SeeList()
        {
            return View();
        }
    }
}