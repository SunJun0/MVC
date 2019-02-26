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
            return View();
        }
        public ActionResult ShowProfit()
        {
            return View();
        }
        public ActionResult ShowPrice()
        {
            //string result = HttpClientHelper.Send("get", "/api/Employees/ShowPrice", null);
            //List<Market> jias = JsonConvert.DeserializeObject<List<Market>>(result);
            //ViewBag.ss = jias;
            return View();
        }
        //员工上个月的工资 
        public ActionResult ShowWages()
        {
            //string result = HttpClientHelper.Send("get", "/api/Employees/ShowPrice", null);
            //List<Market> jias = JsonConvert.DeserializeObject<List<Market>>(result);
            //ViewBag.ss = jias;
            return View();
        }
    }
}