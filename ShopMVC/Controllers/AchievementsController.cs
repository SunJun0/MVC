using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public class AchievementsController : Controller
    {
        // GET: Achievements
        //销售排行
        public ActionResult GetAchievements()
        {
            return View();
        }
        public ActionResult Zhuye()
        {
            return View();
        }
    }
}