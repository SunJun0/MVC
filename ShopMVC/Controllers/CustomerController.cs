using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        //客户注册
        public ActionResult Index()
        {
            return View();
        }
    }
}