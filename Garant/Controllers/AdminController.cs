using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Garant.Models;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;

namespace Garant.Controllers
{

    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {

        private ApplicationContext db;
        private IWebHostEnvironment appEnvironment;

        public AdminController(ApplicationContext db, IWebHostEnvironment appEnvironment)
        {
            this.db = db;
            this.appEnvironment = appEnvironment;
        }


        [HttpGet]
        public IActionResult Index()
        {
            List<Article> articles = db.Articles.ToList();

            return View(articles);
        }

        public IActionResult NewArticle()
        {
            return View();
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
        public IActionResult Update(int id, string title, int timetoread, string content, IFormFile img)
        {

            string imgName = "";

            if (img != null)
            {
                string fileExtension = Path.GetExtension(img.FileName);
                imgName = DateTime.Now.Ticks + fileExtension;

                string path = appEnvironment.WebRootPath + "/img/" + imgName;

                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    img.CopyTo(fileStream);
                }
            }
            else
            {
                imgName = "partnershipa.jpg";
            }

            Article article = db.Articles.FirstOrDefault(article => article.id == id);

            if(article == null)
            {
                return NotFound();
            }

            article.Title = title;
            article.TimeToRead = timetoread;
            article.Content = content;
            article.Img = imgName;

            db.SaveChanges();

            return RedirectToAction("Index", "Article", id);

        }

        [HttpPost]
        public IActionResult Create(string title, int timetoread, string content, IFormFile img)
        {

            string imgName = "";

            if(img != null)
            {
                string fileExtension = Path.GetExtension(img.FileName);
                imgName = DateTime.Now.Ticks + fileExtension;

                string path = appEnvironment.WebRootPath + "/img/" + imgName;

                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    img.CopyTo(fileStream);
                }
            }
            else
            {
                imgName = "partnershipa.jpg";
            }

            Article article = new Article()
            {
                Title = title,
                TimeToRead = timetoread,
                Content = content,
                Img = imgName
            };

            db.Articles.Add(article);

            db.SaveChanges();

            return RedirectToAction("Index", "Article");

        }

    }
}
