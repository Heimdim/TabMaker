using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabmaker.Server.Model
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Members { get; set; }
    }
}
