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
                {2,70},
                {3,85},
                {4,95},
                {5,100}
            };
        }

        public override bool PerformAction(GameProgress gameProgress)
        {
            //If there are two hacked nodes, hack and win for the hackers! Or... if there are two secured nodes, then the hacker has no choice but to hack..
            var perfomHack = gameProgress.Audit.Where(node => node.Outcome == "Hacked").Count() == 2 || gameProgress.Audit.Where(node => node.Outcome == "Secured").Count() == 2;
            if (perfomHack)
            {
                return false;
            }
            else
            {
                //Hacker will either hack or secure the node...
                var random = new Random();
                var randomNumber = random.Next(1, 100);
                //Increase the odds of the player, by 10%, hacking the node if player is Shadowbeatz or TheG18 cause they're known to be risky and hack
                var doHackNode = randomNumber <= _hackerProbabilities[gameProgress.Node] + (this.Name == "ShadowBeatz" || this.Name == "TheG18" ? 10 : 0);
                return !doHackNode;
            }
        }
    }
}
