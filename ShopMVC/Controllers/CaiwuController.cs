using Newtonsoft.Json;
using ShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public class CaiwuController : Controller
    {
        // GET: Caiwu
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ShowMarket()
        {
            string result = HttpClientHelper.Send("get", "/api/Employees/ShowMarket", null);
            List<Market> jias = JsonConvert.DeserializeObject<List<Market>>(result);
            return View(jias);
        }
        public ActionResult ShowProfit()
        {
            return View();
        }
    }
}