using CrewMindnight.DTOs;
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

        public override bool PerformAction(GameProgress gameProgress)
        {
            var hackersWon = gameProgress.Audit.Where((node) => node.Outcome == "Hacked").Count() == 2;
            if (hackersWon)
            {
                return false;
            }
            else
            {
                //Hacker will either hack or secure the node...
                var random = new Random();
                var randomNumber = random.Next(1, 100);
                var doHackNode = randomNumber <= _hackerProbabilities[gameProgress.Node];
                return !doHackNode;
            }
        }
    }
}
