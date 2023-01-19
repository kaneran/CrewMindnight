using CrewMindnight.Interfaces;

namespace CrewMindnight.Entities
{
    public class Agent : Player , IPlayerAction
    {
        public Agent(string name) : base(name)
        {
        }

        public bool PerformAction()
        {
            throw new NotImplementedException();
        }
    }
}
