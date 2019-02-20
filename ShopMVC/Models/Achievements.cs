using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Models
{
   public class Achievements   //员工业绩表
    {
        public int AId { get; set; }  //主键
        public int AEId { get; set; } //外键，关联员工信息表的主键
        public int AMonth { get; set; }  //月度
        public float ASale { get; set; }  //销售额
    }
}
