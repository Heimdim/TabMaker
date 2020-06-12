using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabmaker.Server.Model.Tournir
{
    public class Clash
    {
        public int Id { get; set; }
        public Team AffirmativeTeam { get; set; }
        public Team NegativeTeam { get; set; }
        public int WinnerTeamId { get; set; }
        public Round Round { get; set; }
    }
}
