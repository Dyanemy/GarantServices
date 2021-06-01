using Garant.Models;
using Garant.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Garant.Controllers
{
    public class DealsController : Controller
    {
        private readonly ISqlBaseRepository _db;

        public DealsController(ISqlBaseRepository db)
        {
            _db = db;
        }

        public int QurencyDealID { get; set; }

        [HttpGet]
        public IActionResult CreateDeal()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }
        [HttpPost]
        public IActionResult CreateDeal(Deal dealmodel)
        {
            User author = _db.GetUserByLogin(User.Identity.Name);
            User executor = _db.GetUserByLogin(dealmodel.LoginForExucator);
            if(executor != null)
            {
                if (author != null)
                {
                    if(author.QurencyBallance >= dealmodel.QurencySumma)
                    {
                        if(author.Active == false && executor.Active == false)
                        {
                            var deal = _db.AddDeal(dealmodel.NameDeal, dealmodel.Explanation, executor.Id, dealmodel.QurencySumma, dealmodel.DayForFinish, author.Id);
                            _db.ChangeStatusForParticipantsDeal(executor.Id, author.Id, _db.SearchDeals(author.Id));
                            return Redirect("/Home/Index");
                        }
                    }
                }
            }
            return Redirect("/Home/help");
        }
        [HttpGet]
        public IActionResult GarantDealProcess()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            if(QurencyDealID != 0)
            {
                ViewBag.IdDealUser = QurencyDealID;
                ViewBag.DealInfo = _db.GetDealInfo(QurencyDealID);
                User author = _db.GetUserByID(ViewBag.DealInfo.IdAuthor);
                User executor = _db.GetUserByID(ViewBag.DealInfo.IdExecutor);
                ViewBag.NameAuthor = author.UserName;
                if (User.Identity.IsAuthenticated)
                {
                    if (author.UserName == User.Identity.Name || executor.UserName == User.Identity.Name)
                    {
                        return View();
                    }
                    return Redirect("/Home/Index");
                }
                else return Redirect("/Account/Login");
            }
            else return Redirect("/Home/Index"); //Начнем пожалуй с роли и частичного представления страницы перед завершением заказа
        }
        public IActionResult Chat()
        {
            return View();
        }
    }
}
