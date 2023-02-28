using CrewMindnight.Interfaces;

namespace CrewMindnight.Entities
{
    public class Hacker : Player, IPlayerAction
    {
        private Dictionary<int, int> _hackerProbabilities;
        public Hacker(string name) : base(name, "Hacker")
        {
            _hackerProbabilities = new Dictionary<int, int>()
            {
                {1,20},
                {2,75},
                {3,85},
                {4,95},
                {5,100}
            };
        }

        public override bool PerformAction(int node)
        {
            var random = new Random();
            var randomNumber = random.Next(1,100);
            var doHackNode = randomNumber <= _hackerProbabilities[node];
            return !doHackNode;
        }
    }
}
