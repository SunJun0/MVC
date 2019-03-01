using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ShopMVC.Controllers
{
    public class BoosGoodsController : Controller
    {
        // GET: BoosGoods
        public ActionResult Add()//商品入库
        {
            return View();
        }
        public string File(HttpPostedFileBase file)//文件上传
        {
            if (file != null)//判断不为空
            {
                var path = Server.MapPath("/Images1/");//获取绝对路径
                var filename = DateTime.Now.ToString("yyyyMMddHHmmss") + file.FileName;//用时间格式防止文件重名
                file.SaveAs(path + filename);//保存文件
            }
            return "1";
        }
        public ActionResult Index()//商品库存
        {
            return View();
        }
        public ActionResult Head()//首页
        {
            return View();
        }

    }
}