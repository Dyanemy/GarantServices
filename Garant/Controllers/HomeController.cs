using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Garant.Models;
using System.Net.Mail;
using Garant.Services;

namespace Garant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Service service;
        private readonly ISqlBaseRepository _db;
        public int QurencyDealID { get; set; }

        public HomeController(ILogger<HomeController> logger, Service service, ISqlBaseRepository db)
        {
            _logger = logger;
            this.service = service;
            _db = db;
        }
        public IActionResult Index()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }
        public IActionResult comments()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }
        public IActionResult ErrorFindOfPage()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }

        public IActionResult contact()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }

        public IActionResult help()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }
        public IActionResult join()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }

        public IActionResult static2()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }

        public IActionResult Login()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View(); 
        }
        public IActionResult staticpage()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }
        public IActionResult DisputeResolution()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }
        public IActionResult Deal()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View();
        }
        [HttpPost]
        public IActionResult contact(Email em)
        {
            string name = em.Name;
            string subject = em.Subject;
            string body = em.Body;
            MailMessage mm = new MailMessage();
            mm.To.Add("iprusevich@gmail.com");
            mm.Subject = subject;
            mm.Body = name + " "+ body;
            mm.From = new MailAddress("d1msogarant@gmail.com");
            mm.IsBodyHtml = false;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("iwannaparadise@gmail.com", "");
            smtp.Send(mm); 
            return View();
        }
        public IActionResult SendEmail()
        {
            service.SendEmail();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            QurencyDealID = _db.GetUserQurencyDeal(User.Identity.Name);
            ViewBag.IdDealUser = QurencyDealID;
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
