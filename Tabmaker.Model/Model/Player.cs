using Tabmaker.Server.Model;

namespace Tabmaker.Model.Model
{
    public class Player : User
    {
        public Position Position { get; set; }
        public double PersonalPoints { get; set; }
        public int ClassNumber { get; set; }
        public string AdditionalInfo { get; set; }

        public int? TeamId { get; set; }
       // public Team Team { get; set; }

    }
}
