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
        public int RowNum { get; set; }  //数据库生成的排名列
        public Double payroll { get; set; } //总进价金额

        public int EId { get; set; }  //主键，自增列
        public string EName { get; set; }  //员工姓名
        public string ESex { get; set; }  //员工性别
        public DateTime EHiredate { get; set; }  //入职时间
        public string EPwd { get; set; }  //密码
        public int ERole { get; set; }    //角色，判断是老板还是员工
        public int EState { get; set; }   //在职状态
    }
}
