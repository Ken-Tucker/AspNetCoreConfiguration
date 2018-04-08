﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SettingsDemo.Models;

namespace SettingsDemo.Controllers
{
    public class HomeController : Controller
    {
		private SiteSettings siteSettings;

		public HomeController(IOptions<SiteSettings> settings)
        {
            siteSettings = settings.Value;
            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
			ViewData["Message"] = $"Your contact page. {siteSettings.Title}";
            
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
