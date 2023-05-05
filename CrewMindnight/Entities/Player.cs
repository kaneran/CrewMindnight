using CrewMindnight.DTOs;
using CrewMindnight.Interfaces;

namespace CrewMindnight.Entities
{
    public class Player : IPlayerAction
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public PlayerConfig PlayerConfig { get; set; }

        public int Id { get; set; }

        public Player(string name, string role, PlayerConfig playerConfig)
        {
            Name = name;
            Role = role;
            PlayerConfig = playerConfig;
        }

        public virtual bool PerformAction(GameProgress gameProgress) => true;
    }
}
