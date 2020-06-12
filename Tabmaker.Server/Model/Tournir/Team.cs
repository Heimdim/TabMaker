using System;
using System.Collections.Generic;


namespace Tabmaker.Server.Model.Tournir
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TournirPlayer> Players { get; set; }
        public ICollection<Clash> Clashes { get; set; }
        public Tournir Tournir { get; set; }
        
    }
}
