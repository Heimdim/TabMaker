

namespace Tabmaker.Server.Model
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Club Club { get; set; }
        public string AdditionalInfo { get; set; }

    }
}
