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
        public User author { get; set; }
        public User executor { get; set; }
        public Deal qdeal { get; set; }
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
                            if (dealmodel.DayForFinish > 0)
                            {
                                if (dealmodel.QurencySumma >= 10)
                                {
                                    var deal = _db.AddDeal(dealmodel.NameDeal, dealmodel.Explanation, executor, dealmodel.QurencySumma, dealmodel.DayForFinish, author);
                                    _db.ChangeStatusForParticipantsDeal(executor.Id, author.Id, _db.SearchDeals(author.Id));
                                    return Redirect("/Home/Index");
                                }
                            }
                        }
                    }
                }
            }
            return Redirect("/Deals/ErrorPageDeals");
        }
        [HttpGet]
        public IActionResult ErrorPageDeals()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GarantDealProcess()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            if(QurencyDealID != 0)
            {
                ViewBag.IdDealUser = QurencyDealID;
                ViewBag.DealInfo = _db.GetDealInfo(QurencyDealID);
                qdeal = _db.GetDealInfo(QurencyDealID);
                author = _db.GetUserByID(ViewBag.DealInfo.IdAuthor);
                executor = _db.GetUserByID(ViewBag.DealInfo.IdExecutor);
                ViewBag.QDeal = qdeal;
                ViewBag.Author = author;
                ViewBag.Executor = executor;
                ViewBag.DialogID = qdeal.DialogID;
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
            else return Redirect("/Home/Index");
        }
        public IActionResult Chat()
        {
            return View();
        }
        public IActionResult AcceptDealByExecutor() //Подтверждение заказа от исполнителя
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            if (QurencyDealID != 0)
            {
                qdeal = _db.GetDealInfo(QurencyDealID);
                author = _db.GetUserByID(qdeal.IdAuthor);
                if (qdeal.Status == "В ожидании подтверждения")
                {
                    qdeal.AcceptForExucator = true;
                    _db.TakeAwayMoneyForUser(author.UserName, qdeal.QurencySumma);
                    qdeal.Status = "В выполнении";
                    _db.SaveUserChanges(author);
                    _db.SaveDealChanges(qdeal);
                }
            }
            return Redirect("/Deals/GarantDealProcess");
        }
        public IActionResult CompleateDeal()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            if (QurencyDealID != 0)
            {
                qdeal = _db.GetDealInfo(QurencyDealID);
                author = _db.GetUserByID(qdeal.IdAuthor);
                executor = _db.GetUserByID(qdeal.IdExecutor);
                if(qdeal.Status == "В выполнении")
                {
                    executor.QurencyBallance += qdeal.QurencySumma;
                    executor.Active = false;
                    author.Active = false;
                    executor.QurencyDeals = 0;
                    author.QurencyDeals = 0;
                    qdeal.Status = "Завершена";
                    qdeal.QurencySumma = 0;
                    qdeal.FinishAcceptForAuthor = true;
                    qdeal.FinishAcceptForExecutor = true;
                    _db.SaveDealChanges(qdeal);
                    _db.SaveUserChanges(author);
                    _db.SaveUserChanges(executor);
                }
            }
            return Redirect("/Deals/GarantDealProcess");
        }
        public IActionResult CancelDeal()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            if (QurencyDealID != 0)
            {
                qdeal = _db.GetDealInfo(QurencyDealID);
                author = _db.GetUserByID(qdeal.IdAuthor);
                executor = _db.GetUserByID(qdeal.IdExecutor);
                if(qdeal.Status != "Завершена" && qdeal.Status != "Отменена")
                {
                    if(qdeal.Status == "В выполнении") author.QurencyBallance += qdeal.QurencySumma;
                    executor.Active = false;
                    author.Active = false;
                    executor.QurencyDeals = 0;
                    author.QurencyDeals = 0;
                    qdeal.Status = "Отменена";
                    qdeal.QurencySumma = 0;
                    qdeal.FinishAcceptForAuthor = true;
                    qdeal.FinishAcceptForExecutor = true;
                    _db.SaveDealChanges(qdeal);
                    _db.SaveUserChanges(author);
                    _db.SaveUserChanges(executor);
                }
            }
            return Redirect("/Deals/GarantDealProcess");
        }
    }
}
