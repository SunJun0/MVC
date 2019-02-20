using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Models
{
   public class Market  //订单表
    {
        public int MId { get; set; }  //主键
        public string MCard { get; set; }  //订单编号
        public int MNnum { get; set; }   //购买数量
        public int ShopId { get; set; }  //关联商品信息表主键
    }
}
