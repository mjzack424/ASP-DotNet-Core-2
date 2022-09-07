using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNetCore2DataLayer.Entities.User
{
    public class User
    {
        public User()
        {
                
        }


        [Key]
        public int UserId { get; set; }

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

        [Display(Name = "کد فعال سازی")]
        public string ActiveCode { get; set; }

        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }

        [Display(Name = "آواتر")]
        public string UserAvatar { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }

        #region Relations

        public virtual List<UserRole> UserRoles { get; set; }

        #endregion
    }
}
