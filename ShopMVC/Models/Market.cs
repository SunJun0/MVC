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
        public DateTime MTime { get; set; }  //  --售出时间
        public int Profit { get; set; }    //利润
        public int month { get; set; }    //月份

        public int GId { get; set; }  //主键
        public string GName { get; set; }  //名称
        public string GColor { get; set; }  //颜色
        public int GSize { get; set; }   //尺寸
        public int GQuantity { get; set; }  //数量
        public float GPrice { get; set; }   //进价
        public float GPricing { get; set; }  //定价  
        public string GPicture { get; set; }  //图片
        public int GState { get; set; }   //商品状态
        public float Zong { get; set; } //总进价金额
        
    }
}
