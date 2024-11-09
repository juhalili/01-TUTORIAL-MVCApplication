﻿using Microsoft.AspNetCore.Mvc;

namespace MVCApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

        public string IndexStranica()
        {
            return "This is the index page";
        }

        public string Hello()
        {
            return "Hello";
        }
    }
}
