﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DotNetCore2DataLayer.Entities.User
{
    public class UserRole
    {
        public UserRole()
        {

        }


        [Key]
        public int URId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }

        

        #region Relations
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }



        #endregion

    }
}
