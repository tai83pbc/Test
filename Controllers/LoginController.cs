﻿using LearnWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearnWeb.Controllers
{
	public class LoginController : Controller
	{
        public IActionResult Index()
        {
            return View("Login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
