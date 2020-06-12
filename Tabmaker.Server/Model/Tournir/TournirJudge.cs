using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabmaker.Server.Model.Tournir
{
    public class TournirJudge:User
    {
        public ICollection<Clash> Clashes { get; set; }
        public int PersonalScores { get; set; }

    }
}
