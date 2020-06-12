using System;
using System.Collections.Generic;


namespace Tabmaker.Server.Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<IPlayer> Players { get; set; }
        public ICollection<Clash> Clashes { get; set; }
        public Tournir Tournir { get; set; }
        
    }
}
