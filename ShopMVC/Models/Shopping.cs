using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMVC.Models
{
    public class Shopping
    {

        public int SId { get; set; }

        public int SNum { get; set; }

        public int GId { get; set; }

        public bool SState { get; set; }

        public string GName { get; set; }  //名称
        public string GColor { get; set; }  //颜色
        public int GSize { get; set; }   //尺寸
        public float GPricing { get; set; }  //定价  
    }
}