using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
