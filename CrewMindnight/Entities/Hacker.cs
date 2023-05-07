using CrewMindnight.DTOs;
using CrewMindnight.Interfaces;

namespace CrewMindnight.Entities
{
    public class Hacker : Player, IPlayerAction
    {
        private Dictionary<int, int> _hackerProbabilities;
        private Random _random;
        public Hacker(string name, PlayerConfig playerConfig = null) : base(name, "Hacker", playerConfig)
        {
            _hackerProbabilities = new Dictionary<int, int>()
            {
                {1,20},
                {2,70},
                {3,85},
                {4,95},
                {5,100}
            };
            _random = new Random();
        }
        
        public override bool PerformAction(GameProgress gameProgress)
        {
            //If there are two hacked nodes, hack and win for the hackers!
            if (gameProgress.Audit.Where(node => node.Result == "Hacked").Count() == 2)
            {
                return false;
            }

            //If there's two hackers in the node then decrease the likelihood (65%) of them hacking to prevent two hackers detected 
            else if(gameProgress.Participants.Where(participant => participant.Role == "Hacker").Count() == 2)
            {
                return DecideAction(65);
            }

            //If there are two secured nodes, then the hacker has no choice but to hack..
            else if(gameProgress.Audit.Where(node => node.Result == "Secured").Count() == 2)
            {
                return false;
            }
            else
            {
                return DecideAction(_hackerProbabilities[gameProgress.Node]);
            }
        }

        //Hacker will either hack or secure the node..
        public bool DecideAction(int probability)
        {
            var randomNumber = _random.Next(1, 100);
            //Increase the odds of the player, by 10%, hacking the node if player is Shadowbeatz or TheG18 cause they're known to be risky and hack
            var doHackNode = randomNumber <= probability + (this.Name == "ShadowBeatz" || this.Name == "TheG18" ? 10 : 0);
            return !doHackNode;
        }
    }
}
