using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabmaker.Server.Model.Tournir
{
    public class Round
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Topic { get; set; }
        public byte[] Infoslide { get; set; }
        public ICollection<Clash> Clashes { get; set; }
        public Tournir Tournir { get; set; }
    }
}
