using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVC.Models
{
    public class Users
    {
        private int Id { get; set; }

        [Display(Name = "用户名"), MinLength(3), MaxLength(20)]
        [Required(ErrorMessage = "用户名必填")]
        public string UserName { get; set; }

        [Display(Name = "密码"), MinLength(6), MaxLength(20)]
        [Required(ErrorMessage = "密码必填")]
        public string Password { get; set; }


        [Display(Name = "姓名")]
        [Required(ErrorMessage = "姓名必填")]
        public string Name { get; set; }

        [Display(Name = "电子邮箱")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "年龄")]
        [Range(0, 120)]
        public int Age { get => Age; set { if (Age < 0) Age = 0; } }

        [Display(Name = "性别")]
        
        public Sex sex { get; set; }

    }
}
