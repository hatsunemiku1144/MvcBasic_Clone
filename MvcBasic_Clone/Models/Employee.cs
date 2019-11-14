using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcBasic_Clone.Models
{
    public class Employee
    {
        [Display(Name = "員工編號")]
        public int Id { get; set; }
        //EmployeeID
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "連絡電話")]
        public string Phone { get; set; }
        [Display(Name = "電子郵件")]
        public string Email { get; set; }
    }
}