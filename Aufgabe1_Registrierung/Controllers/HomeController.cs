﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Aufgabe1_Registrierung.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Startseite()
        {
            return View();
        }
    }
}