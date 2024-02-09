﻿using Microsoft.AspNetCore.Mvc;
using ProjectCasaDespa.Models;
using System.Diagnostics;

namespace ProjectCasaDespa.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult FAQs()
        {
            return View();
        }

        public IActionResult Profile()
        {
   
            return View();
        }

        public IActionResult ProfileP()
        {
            return View();
        }

        public IActionResult Receipt()
        {
            return View();
        }

        public IActionResult Booking()
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