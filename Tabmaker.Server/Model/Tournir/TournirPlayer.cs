using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabmaker.Server.Model.Tournir
{
    public class TournirPlayer :User
    {
        public Team Team { get; set; }
        public Position Position { get; set; }
        public ICollection<Clash> Clashes { get; set; }
        public int PersonalScores { get; set; }

        public TournirPlayer(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public TournirPlayer()
        {
        }
    }
}
