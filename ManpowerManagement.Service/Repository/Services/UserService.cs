using System;
using System.Collections.Generic;
using System.Text;
using ManpowerManagement.Data.Context;
using ManpowerManagement.Data.Model;
using ManpowerManagement.Service.Repository.Interface;
using ManpowerManagement.Service.Repository.Srvics;
using Microsoft.EntityFrameworkCore;

namespace ManpowerManagement.Service.Repository.Services
{
    public class UserService : Repository<User>, IUser
    {
        private ManpowerContext _context;
        public UserService(DbContext db) : base(db)
        {
            _context = (ManpowerContext)db;
        }
    }
}
