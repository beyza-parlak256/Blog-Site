﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class KaliteController : Controller
    {
        public IActionResult Kalite()
        {
            return View();
        }
    }
}
