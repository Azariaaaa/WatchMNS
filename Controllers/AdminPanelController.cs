﻿using Microsoft.AspNetCore.Mvc;

namespace WatchMNS.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}