﻿using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {
            return View("Common");
            // Changing name from Index to Common
        }
    }
}
