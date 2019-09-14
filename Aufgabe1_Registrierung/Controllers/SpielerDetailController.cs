using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Aufgabe1_Registrierung.Models;
using Microsoft.AspNetCore.Mvc;
using Aufgabe1_Registrierung;
using Aufgabe1_Registrierung.Data;


namespace Aufgabe1_Registrierung.Controllers
{
    public class SpielerDetailController : Controller
    {

        public IActionResult SeeSpieler(string Vorname, string Nachname, string Telefon, string Email, string Jahrgang)
        {
            Spieler newSpieler = new Spieler() { vorname = Vorname, email = Email, jahrgang = Jahrgang, nachname = Nachname, telefon = Telefon };


            SpielerRepo.SpielerListe.Add(newSpieler);

            return View(newSpieler);
        }

        //Folie 4-21 doch es geht noch einfacher
        // *************************************************************************************

        //public IActionResult SeeSpieler2()
        //{
        //    Spieler newSpieler = null;

        //    if (Request.Method.Equals("GET"))
        //    {

        //        newSpieler = new Spieler()
        //        {
        //            vorname = Request.Query["Vorname"],
        //            email = Request.Query["Email"],
        //            jahrgang = Request.Query["Jahrgang"],
        //            nachname = Request.Query["Nachname"],
        //            telefon = Request.Query["Telefon"]
        //        };
        //    }

        //    else if (Request.Method.Equals("POST"))
        //    {
        //        newSpieler = new Spieler()
        //        {
        //            vorname = Request.Form["Vorname"],
        //            email = Request.Form["Email"],
        //            jahrgang = Request.Form["Jahrgang"],
        //            nachname = Request.Form["Nachname"],
        //            telefon = Request.Form["Telefon"]
        //        };
        //    }

        //    SpielerRepo.SpielerListe.Add(newSpieler);

        //    return View("SeeSpieler", newSpieler);
        //}

        //Folie 4-23 (Explizites Model-Binding > doch es geht noch einfacher
        // *************************************************************************************
        //public ActionResult SeeSpieler2()
        //{
        //    Spieler newSpieler = new Spieler();
        //    try
        //    {
        //        if (TryUpdateModelAsync(newSpieler).Result)
        //        {
        //        } 
        //    }
        //    catch (Exception e)
        //    {
        //                Console.WriteLine(e);
        //                throw;
        //    }

        //    SpielerRepo.SpielerListe.Add(newSpieler);

        //    return View("SeeSpieler", newSpieler);
        //}

        //Folie 4-24 (Implizites Model-Binding > sehr schlanke, elegante Art
        // *************************************************************************************

        public ActionResult SeeSpieler2(Spieler spieler)
        {
            SpielerRepo.SpielerListe.Add(spieler);
            return View("SeeSpieler", spieler);
        }
    }
}