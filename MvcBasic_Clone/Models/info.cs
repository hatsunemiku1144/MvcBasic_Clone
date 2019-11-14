using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Info
    {      
        public int Id { get; set; }
        [Display(Name ="姓名")]
        [Required(ErrorMessage ="姓名為必填欄位")]
        [StringLength(25,MinimumLength =2,ErrorMessage ="請輸入最少二個字，最多二十五個字")]
        public string Name { get; set; }
        [Display(Name="電話")]
        //[RegularExpression(@"^\d{4}\-?d{3}-?d{3}$",ErrorMessage ="請輸入正確格式(09XX-XXX-XXX)") ]
        [Required]
        public int Telphone { get; set; }
        [Display(Name="地址")]
        [Required(ErrorMessage ="必須輸入地址")]
        public string Email { get; set; }
        [Display(Name ="性別")]
        [Required(ErrorMessage ="必須輸入性別")]
        public string Gender { get; set; }

    }
}