using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Garant.Models;

namespace Garant.Controllers
{

    public class ArticleController : Controller
    {

        ApplicationContext db;

        public ArticleController(ApplicationContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            List<Article> articles = db.Articles.ToList();

            return View(articles);
        }

        [Route("{controller}/{id}")]
        public IActionResult Index(int id)
        {
            Article article = db.Articles.FirstOrDefault(article => article.id == id);

            if(article == null)
            {
                return NotFound();
            }

            

            return View("ArticlePost", article);
        }

    }
}
