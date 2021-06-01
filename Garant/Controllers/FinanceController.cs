using Garant.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Controllers
{
    public class FinanceController : Controller
    {
        private readonly ISqlBaseRepository _db;

        public FinanceController(ISqlBaseRepository db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult AddMoney()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMoney(int entersumma)
        {
            if (entersumma < 100000)
            {
                _db.AddMoneyToUser(User.Identity.Name, entersumma);
                return Redirect("/Home/DetailUser");
            }
            else return Redirect("/Home/Index");
        }
    }
}
