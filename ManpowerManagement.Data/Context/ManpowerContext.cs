using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ManpowerManagement.Data.Model;

namespace ManpowerManagement.Data.Context
{
    public class ManpowerContext : DbContext
    {
        public ManpowerContext(DbContextOptions<ManpowerContext> options)
    : base(options)
        {
        }
        public DbSet<User> User { get; set; }
    }
}
