
using System.Data.Entity;

using Tabmaker.Server.Model;

namespace Tabmaker.Server.Context
{
    public class UserContext : DbContext
    {
        public UserContext() : base("tabmaker_db")
        { }

        public DbSet<User> Users { get; set; }
    }
}
