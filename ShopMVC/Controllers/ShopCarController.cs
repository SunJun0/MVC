using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopMVC.Models;

namespace ShopMVC.Controllers
{
    public class ShopCarController : Controller
    {
        // GET: ShopCar
        public ActionResult ShopIndex()
        {
            return View();
        }
        [HttpPost]
        public void ShopIndex(Goods Shop)
        {

        }
    }
}