﻿using Microsoft.AspNetCore.Mvc;

namespace Core_Project.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
