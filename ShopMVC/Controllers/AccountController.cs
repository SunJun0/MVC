using Newtonsoft.Json;
using ShopMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            ViewBag.ID = 0;
            return View();
        }
        //[HttpPost]
        //public ActionResult Login(string name, string pwd)
        //{
        //    string result = GetApiResult.Use("get", "Login/?name=" + name + "&pwd=" + pwd, "http://localhost:55237/api/account/");
        //    Employees e = JsonConvert.DeserializeObject<Employees>(result);
        //    if (e != null)
        //    {
        //        Session["employee"] = e;
        //        return Content("1");
        //    }
        //    else
        //    {
        //        return Content("0");
        //    }
        //}
    }
}