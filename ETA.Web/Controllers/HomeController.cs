﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ETA.Data.DAL;

namespace ETA.Web.Controllers
{
    public class HomeController : Controller
    {
        private ETAContext context;

        public HomeController(ETAContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            var mydata = context.Group.FirstOrDefault();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
