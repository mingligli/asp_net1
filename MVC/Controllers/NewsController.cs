using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
           IList<string> news = new List<string>();
            int count=new Random().Next(3, 5);
            for (int i = 0; i < count; i++)
            {
                news.Add($"这是新闻标题 {i+1}");
            }
            return View(news);
        }
    }
}