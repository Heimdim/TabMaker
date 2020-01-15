    using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabmaker.Server.Model;

namespace Tabmaker.Server.Context
{
    class UserContext : DbContext
    {
        public UserContext() : base("tabmaker_db")
        { }

        public DbSet<User> Users { get; set; }
    }
}
