﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShotgeneratorProject.Controllers
{
    public class GeneratorController : Controller
    {
      
        public ActionResult Customize()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}