﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        // Тестируем передачц параметров через ViewBag
        public ActionResult Welcome(string name, int numtimes = 1)
        {
            ViewBag.Message = "Hello, " + name;
            ViewBag.NumTimes = numtimes;
            return View();

        }
    }
}