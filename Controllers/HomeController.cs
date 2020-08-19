﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using PioPage.Models;

namespace PioPage.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Year = DateAndTime.Year(DateTime.Now);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SingUp()
        {
            return View();
        }

        public IActionResult Author()
        {
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Tech()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
