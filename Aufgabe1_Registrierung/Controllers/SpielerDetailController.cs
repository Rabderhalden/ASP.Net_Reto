using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aufgabe1_Registrierung.Models;
using Microsoft.AspNetCore.Mvc;
using Aufgabe1_Registrierung;


namespace Aufgabe1_Registrierung.Controllers
{
    public class SpielerDetailController : Controller
    {

        public IActionResult SeeSpieler(string Vorname, string Nachname, string Telefon, string Email, string Jahrgang)
        {
            Spieler newSpieler = new Spieler(){vorname = Vorname,email=Email, jahrgang = Jahrgang, nachname = Nachname,telefon = Telefon};

            List<Spieler> spieler = new List<Spieler>();

            spieler.Add(newSpieler);

            ViewData.Model = spieler;


            //ViewBag.Vorname = Vorname;
            //ViewBag.Nachname = Nachname;
            //ViewBag.Telefon = Telefon;
            //ViewBag.Email = Email;
            //ViewBag.Jahrgang = Jahrgang;
            return View(newSpieler);
        }
    }
}