using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Models
{
    public class Employees   //员工信息表
    {
        [Key]
        [Display(Name = "编号")]
        public int EId { get; set; }  //主键，自增列
        [Display(Name= "姓名")]
        public string EName { get; set; }  //员工姓名
        [Display(Name = "性别")]
        public string ESex { get; set; }  //员工性别
        [Display(Name = "入职时间")]
        public DateTime EHiredate { get; set; }  //入职时间
        [Display(Name = "密码")]
        public string EPwd { get; set; }  //密码
        [Display(Name = "角色")]
        public int ERole { get; set; }    //角色，判断是老板还是员工
        [Display(Name = "在职状态")]
        public int EState { get; set; }   //在职状态
    }
}
