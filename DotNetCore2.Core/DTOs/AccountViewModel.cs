using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNetCore2.Core.DTOs
{
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0} لطفا اصلاح بفرمایید")]
        public string UserName { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0} لطفا اصلاح بفرمایید")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0} لطفا اصلاح بفرمایید")]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "نمی تواند بیشتر از {1} کاراکتر باشد {0} لطفا اصلاح بفرمایید")]
        public string RePassword { get; set; }
    }
}
