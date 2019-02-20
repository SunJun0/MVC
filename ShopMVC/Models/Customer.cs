using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Models
{
   public class Customer //顾客信息
    {
        public int CId { get; set; }  //主键
        public string CName { get; set; }  //顾客姓名
        public string CPhone { get; set; }   //电话
        public int Credits { get; set; }   //积分
    }
}
