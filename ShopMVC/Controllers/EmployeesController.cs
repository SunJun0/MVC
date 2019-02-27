using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using ShopMVC.Models;

namespace ShopMVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        [HttpGet]
        public ActionResult Index()
        {
            string result = HttpClientHelper.Send("get", "/api/Employees/ShowEmployees", null);
            List<Employees> jias = JsonConvert.DeserializeObject<List<Employees>>(result);
            return View(jias);
        }
        [HttpGet]
        public ActionResult AddEmployees()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployees(Employees m)
        {
            string json = JsonConvert.SerializeObject(m);
            string result = HttpClientHelper.Send("post", "/api/Employees/AddEmployees", json);
            if (Convert.ToInt32(result) > 0)
            {
                return Redirect("/Employees/Index");
            }
            else
            {
                return Content("bu ok");
            }
        }

       
    }
}