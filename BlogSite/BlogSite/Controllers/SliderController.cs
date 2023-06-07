using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class SliderController : Controller
    {
        public IActionResult Slider()
        {
            return View();
        }
    }
}
