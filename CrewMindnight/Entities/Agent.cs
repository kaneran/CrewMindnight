using CrewMindnight.Interfaces;

namespace CrewMindnight.Entities
{
    public class Agent : Player , IPlayerAction
    {
        public Agent(string name) : base(name, "Agent")
        {
        }

        public override bool PerformAction(int node) => true;
    }
}
