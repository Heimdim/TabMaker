using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabmaker.Server.Model
{
    public class Tournir
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public ICollection<Team> Teams { get; set; }
        public ICollection<IJudge> Judges { get; set; }
        public ICollection<Round> Rounds { get; set; }


    }
}
