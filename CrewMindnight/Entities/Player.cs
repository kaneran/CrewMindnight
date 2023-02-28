using CrewMindnight.Interfaces;

namespace CrewMindnight.Entities
{
    public class Player : IPlayerAction
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Player(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public virtual bool PerformAction(int node) => true;
    }
}
