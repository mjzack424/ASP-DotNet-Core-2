using DotNetCore2DataLayer.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCore2DataLayer.Context
{
    public class TopLearnContext:DbContext
    {
        public TopLearnContext(DbContextOptions<TopLearnContext> options):base(options)
        {

        }

        #region User

        public DbSet<Role> Roles {get; set;}
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRole { get; set; }



        #endregion
    }
}
