using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Garant.Models;
using Microsoft.AspNetCore.Authorization;

namespace Garant.Controllers
{

    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {

        private ApplicationContext db;

        public AdminController(ApplicationContext db)
        {
            this.db = db;
        }



        public IActionResult Index()
        {
            List<Article> articles = db.Articles.ToList();

            return View(articles);
        }

        [Route("{controller}/{action}/{id}")]
        public IActionResult EditArticle(int id)
        {
            Article article = db.Articles.FirstOrDefault(article => article.id == id);

            if(article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        [HttpPost]
        public IActionResult Update(int id, string title, int timetoread, string content, string img)
        {
            Article article = db.Articles.FirstOrDefault(article => article.id == id);

            if(article == null)
            {
                return NotFound();
            }

            article.Title = title;
            article.TimeToRead = timetoread;
            article.Content = content;
            article.Img = img;

            db.SaveChanges();

            return RedirectToAction("Index", "Article", id);

        }

    }
}
