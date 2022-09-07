using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNetCore2DataLayer.Entities.User
{
    public class Role
    {
        public Role()
        {

        }
        [Key]
        public int ReleId { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage ="لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage ="نمی تواند بیشتر از {1} کاراکتر باشد {0} لطفا اصلاح بفرمایید")]    
        public string RoleTitle { get; set; }



        #region Relation
        public virtual List<UserRole> UserRoles { get; set; }

        #endregion
    }
}
