﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopMVC.Models;
using System.Data;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopMVC.Controllers
{
    public class ShopCarController : Controller
    {
            #region 商品查询
            static List<Goods> list = new List<Goods>();

        string dt = "";
        static int num = 1;
        // GET: ShopCar
        public ActionResult ShopIndex()
        {
            ShopName();
            if (num == 1)
            {
                num = list.Count;
                ViewBag.sum = num;
            }
            else
            {
                ViewBag.sum = 0;
            }

            return View();
        }
        [HttpPost]
        public ActionResult ShopIndex(Goods Shop)
        {
            ShopName();
            if (Shop.GName == null & Shop.GColor == null & Shop.GSize == 0)
            {
                Response.Write("<script>alert('请填写你要查询的商品')</script>");
            }
            else
            {
                dt = HttpClientHelper.Send("get", "/api/ShopCar/DemandShop/?ShopName=" + Shop.GName + "&ShopColor=" + Shop.GColor + "&ShopSize=" + Shop.GSize, null);

                list = JsonConvert.DeserializeObject<List<Goods>>(dt);
                ViewBag.sum = list.Count;
            }
            return View(list);
        }
        #endregion

        #region 绑定下拉（姓名）
        public void ShopName()
        {
            string sn = HttpClientHelper.Send("get", "/api/ShopCar/ShopName", null);

            List<Goods> list = JsonConvert.DeserializeObject<List<Goods>>(sn);

            ViewBag.Gid = new SelectList(list, "GName", "GName");
        }
        #endregion

        #region 添加购物车
        public void AddShopCar(int num)
        {

            Shopping shop = new Shopping();

            shop.SNum = num;

            shop.SState = Convert.ToBoolean(0);

            shop.GId = list[0].GId;



            int i = Convert.ToInt32(GetApiResult.Use("post", "AddShopCar", "http://localhost:55237//api/ShopCar/", shop));

            if (i > 0)
            {
                num = 0;
                Response.Write("<script>alert('添加成功');location.href='/ShopCar/ShopIndex'</script>");
            }
        }
        #endregion

        #region 显示购物车
        static List<Shopping> shoplist = new List<Shopping>();
        public ActionResult ShowShopCar()
        {
            string sj = GetApiResult.Use("get", "ShowShopCar", "http://localhost:55237//api/ShopCar/");

            shoplist = JsonConvert.DeserializeObject<List<Shopping>>(sj);

            float Sum = 0;
            for (int i = 0; i < shoplist.Count(); i++)
            {
                Sum += shoplist[i].SNum * shoplist[i].GPricing;
            }
            ViewBag.Sum = Sum;
            Session["Sum"] = Sum;
            return View(shoplist);
        }
        #endregion

        /// <summary>
        /// 修改购物车状态
        /// 修改商品库存
        /// 添加订单
        /// 修改顾客积分
        /// 修改员工的业绩
        /// 判断是否为vip用户
        /// </summary>
        List<Market> Mlist = new List<Market>();      
        public void TallyOrder(string Phone)
        {
            int j = 0;
            int t = 0;
            Market Mmodel = new Market();
            Shopping shop = new Shopping();
            string time = DateTime.Now.ToString("MMddhhmm");

            for (int i = 0; i < shoplist.Count; i++)
            {
                Mmodel.MCard = time;
                Mmodel.MNnum = shoplist[i].SNum;
                Mmodel.MNnum = shoplist[i].SNum;
                Mmodel.MTime = DateTime.Now;
                Mmodel.ShopId = shoplist[i].GId;
                shop.SId = shoplist[i].SId;
                //提交订单
                j += Convert.ToInt32(GetApiResult.Use("post", "AddTallyOrder", "http://localhost:55237//api/ShopCar/", Mmodel));
                //修改购物车状态
                t += Convert.ToInt32(GetApiResult.Use("put", "UpdateShopCar", "http://localhost:55237//api/ShopCar/", shop));

            }
            if (t == shoplist.Count() && j == shoplist.Count())
            {
                int s = 0;
                Goods goods = new Goods();
                for (int i = 0; i < shoplist.Count(); i++)
                {
                    goods.GId = shoplist[i].GId;
                    goods.GQuantity = shoplist[i].SNum;
                    //修改库存
                    s += Convert.ToInt32(GetApiResult.Use("put", "UpdateKu", "http://localhost:55237//api/ShopCar/", goods));
                }

                string dt = GetApiResult.Use("get", "ShowPhone/?Phone=" + Phone, "http://localhost:55237//api/ShopCar/");

                List<Customer> CList = JsonConvert.DeserializeObject<List<Customer>>(dt);
                model m = new model();
                m.YId = 9;
                m.SumPrice =Convert.ToSingle(Session["Sum"]);
                int d = 0;
                //判断是否为vip用户
                if (CList.Count() > 0)
                {
                    m.GId = CList[0].CId;
                    d = Convert.ToInt32(GetApiResult.Use("put", "UpdateJi", "http://localhost:55237//api/ShopCar/", m));
                }
                else
                {
                    d = Convert.ToInt32(GetApiResult.Use("put", "UpdateJi", "http://localhost:55237//api/ShopCar/", m));
                }
                if (s == shoplist.Count() && d >0)
                {
                    Response.Write("<script>alert('交易完成')</script>");
                }

            }
        }
    }
}