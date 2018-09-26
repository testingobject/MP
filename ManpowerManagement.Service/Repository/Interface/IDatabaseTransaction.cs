using System;
using System.Collections.Generic;
using System.Text;

namespace ManpowerManagement.Service.Repository.Interface
{
    public interface IDatabaseTransaction : IDisposable
    {
        void Commit();

        void Rollback();
    }
}
