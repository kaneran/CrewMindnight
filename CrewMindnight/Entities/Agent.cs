using CrewMindnight.DTOs;
using CrewMindnight.Interfaces;

namespace CrewMindnight.Entities
{
    public class Agent : Player , IPlayerAction
    {
        public Agent(string name, PlayerConfig playerConfig = null) : base(name, "Agent", playerConfig)
        {
        }

        public override bool PerformAction(GameProgress gameProgress) => true;
    }
}
