﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaParisWebApp1.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult InicioSesion()
        {
            return View();
        }
    }
}