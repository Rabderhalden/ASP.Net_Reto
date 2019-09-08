using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aufgabe1_Registrierung.Controllers
{
    public class SpielerDetailController : Controller
    {
        public IActionResult SeeSpieler(string Vorname, string Nachname, string Telefon, string Email, string Jahrgang)
        {
            ViewBag.Vorname = Vorname;
            ViewBag.Nachname = Nachname;
            ViewBag.Telefon = Telefon;
            ViewBag.Email = Email;
            ViewBag.Jahrgang = Jahrgang;
            return View();
        }
    }
}