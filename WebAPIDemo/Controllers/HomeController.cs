﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
        public ActionResult ListProduct()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
        public ActionResult AddProduct()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

    }
}
