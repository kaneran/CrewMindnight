using CrewMindnight.Interfaces;

namespace CrewMindnight.Entities
{
    public class Agent : Player , IPlayerAction
    {
        public Agent(string name) : base(name, "Agent")
        {
        }

        public bool PerformAction(int node) => true;
    }
}
