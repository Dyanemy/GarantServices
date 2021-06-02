using Garant.Models;
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
        User user { get; set; }

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

        [HttpGet]
        public IActionResult TakeAwayMoney()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TakeAwayMoney(int numberphone, int discardsumma)
        {
            user = _db.GetUserByLogin(User.Identity.Name);
            if(discardsumma <= user.QurencyBallance)
            {
                Finance finance = new Finance()
                {
                    NumberPhone = numberphone,
                    Summa = discardsumma,
                    Status = "В ожидании",
                    DataCreated = DateTime.Now,
                    AuthorId = user.Id,
                    AuthorName = user.UserName
                };
                _db.AddRequestFinance(finance);
                _db.TakeAwayMoneyForUser(User.Identity.Name, discardsumma);
            }
            return Redirect("/Home/DetailUser");
        }
    }
}
