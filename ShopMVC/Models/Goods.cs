using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Models
{
   public class Goods   //商品信息表
    {
        public int GId { get; set; }  //主键
        public string GName { get; set; }  //名称
        public string GColor { get; set; }  //颜色
        public int GSize { get; set; }   //尺寸
        public int GQuantity { get; set; }  //数量
        public float GPrice { get; set; }   //进价
        public float GPricing { get; set; }  //定价  
        public string GPicture { get; set; }  //图片
        public int GState { get; set; }   //商品状态
    }
}
