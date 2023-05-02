using CrewMindnight.Entities;

namespace CrewMindnight.Services
{
    public class GameService
    {
        private List<string> _players;
        private Random _random;

        public GameService()
        {
            _players = new List<string>() { "Speedy", "SideArms", "D4", "Shadowbeatz", "TheG18" };
            _random = new Random();
        }
        public IReadOnlyList<Player> CreateGame(string playerName)
        {
            var players = AssignRolesToPlayers(playerName);
            return players;
        }

        public List<Player> AssignRolesToPlayers(string playerName)
        {
            var agents = new List<string>(_players);
            var hackers = new List<string>();
            var players = new List<Player>();

            agents.Add(playerName);

            //Assign hacker role to two players(agents)
            for (int i = 0; i < 2; i++)
            {
                AssignHackerRole(agents, hackers);
            }

            agents.ForEach(agentName =>
            {
                var player = new Agent(agentName);
                players.Add(player);
            });

            hackers.ForEach(hackerName =>
            {
                var player = new Hacker(hackerName);
                players.Add(player);
            });
            //Assign id for each player
            for (int i = 0; i < players.Count; i++)
                players[i].Id = i;
            return players;
        }

        public void AssignHackerRole(List<string> agents, List<string> hackers)
        {
            var agentsCount = agents.Count - 1;
            var randomNumber = _random.Next(0, agentsCount);
            var playerName = agents[randomNumber];
            hackers.Add(playerName);
            agents.RemoveAt(randomNumber);
        }
    }
}
