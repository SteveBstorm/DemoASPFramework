using DemoASPFramework.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoASPFramework.Controllers
{
    public class ArticleController : Controller
    {
      
        // GET: Article
        public ActionResult Index()
        {

            ViewBag.truc = "salut";
            //Exemple Json
            //string json = JsonConvert.SerializeObject(articles);
            //List<Article> la = JsonConvert.DeserializeObject<List<Article>>(json);
            return View(ArticleStocke.articles);
        }

        public ActionResult Bidule()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Article article)
        {
            if(!ModelState.IsValid)
            {
                return View(article);
            }

            ArticleStocke.articles.Add(article);
            return RedirectToAction("Index");
        }
    }
}