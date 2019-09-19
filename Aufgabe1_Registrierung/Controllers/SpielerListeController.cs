using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aufgabe1_Registrierung.Data;
using Aufgabe1_Registrierung.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Aufgabe1_Registrierung.Controllers
{
    public class SpielerListeController : Controller
    {

        public IActionResult SeeList()
        {
            return View(SpielerRepo.SpielerListe);
        }

        public ActionResult Search(string search)
        {
            ViewBag.Spielerliste = new SelectList(SpielerRepo.SpielerListe, "vorname", "nachname");
            //var spieler = SpielerRepo.SpielerListe.Where(a => a.vorname.StartsWith(begriff)).Take(10);
            return View(SpielerRepo.SpielerListe.Where(a=>a.vorname.StartsWith(search)).ToList());
        }
    }
}