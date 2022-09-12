using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNetCore2.Core.Services.Interfaces;
using DotNetCore2DataLayer.Context;
using Microsoft.EntityFrameworkCore.Internal;

namespace DotNetCore2.Core.Services
{
    public class UserService:IUserService
    {
        private TopLearnContext _context;

        public UserService(TopLearnContext context)
        {
            _context = context; 
        }



        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }
    }
}
