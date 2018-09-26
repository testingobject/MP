using System;
using System.Collections.Generic;
using System.Text;
using ManpowerManagement.Service.Repository.Interface;
using ManpowerManagement.Service.Repository.Services;

namespace ManpowerManagement.Service.UnitOfWork
{
   public interface IUnitOfWork
    {
        IUser User { get; }
        int SaveChanges();
        IDatabaseTransaction BeginTrainsaction();
    }
}
