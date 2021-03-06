﻿using DependencyInjection_SmallSupport151220.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection_SmallSupport151220.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BlogDbContext _context;
        //Injection de dépendance à l'aide de l'attribut privé
        public HomeController(ILogger<HomeController> logger, BlogDbContext injectedDbContext)
        {
            _context = injectedDbContext;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_context.Articles);
        }

        public IActionResult Privacy()
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
