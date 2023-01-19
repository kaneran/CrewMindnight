using CrewMindnight.Interfaces;

namespace CrewMindnight.Entities
{
    public class Hacker : Player, IPlayerAction
    {
        public Hacker(string name) : base(name)
        {
        }

        public bool PerformAction()
        {
            throw new NotImplementedException();
        }
    }
}
