﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Car Insurance Quote App via ASP.NET Framework.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sample contact page.";

            return View();
        }
    }
}