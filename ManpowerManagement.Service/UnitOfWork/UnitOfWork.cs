using System;
using System.Collections.Generic;
using System.Text;
using ManpowerManagement.Data.Context;
using ManpowerManagement.Service.Repository.Interface;
using ManpowerManagement.Service.Repository.Services;


namespace ManpowerManagement.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        ManpowerManagement.Data.Context.ManpowerContext _context;
        UserService _userService;
        
        public UnitOfWork(ManpowerManagement.Data.Context.ManpowerContext context)
        {
            _context = context;
        }

        public IUser User
        {
            get
            {
                if (_userService == null)
                    _userService = new UserService(_context);
                return _userService;
            }
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
        public IDatabaseTransaction BeginTrainsaction()
        {
            return new EntityDatabaseTransaction(_context);
        }
    }
}
