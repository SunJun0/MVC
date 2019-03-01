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
        //导出
        public ActionResult Export()
        {
            /*指定Excel行与集合中对象的对应关系*/
            Dictionary<string, string> dts = new Dictionary<string, string>
            {
            {"RowNum","员工排行"},
            {"EName","员工名称"},
            {"ESex","员工性别"},
            {"payroll","员工工资"},
            };
            string result = HttpClientHelper.Send("get", "/api/Employees/ShowWages", null);
            List<Achievements> list = JsonConvert.DeserializeObject<List<Achievements>>(result);
            //调用ExcelHelper，将返回的路径配置新的URl路由规则
            string url = Url.RouteUrl("Download") + ExcelHelper.EntityListToExcel2003(dts, list, "工资表");
            return Content("<script>location.href='" + url + "'</script>");
        }
    }
}