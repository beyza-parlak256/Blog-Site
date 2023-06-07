using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class IcerikController : Controller
    {
        public IActionResult Icerik()
        {
            return View();
        }
    }
}
