using CrewMindnight.DTOs;
using CrewMindnight.Entities;

namespace CrewMindnight.Services
{
    public class GameService
    {
        private List<string> _players;
        private List<PlayerConfig> _playersConfigs;
        private List<Node> _nodes;
        private Random _random;

        public GameService()
        {
            _players = new List<string>() { "Speedy", "SideArms", "D4", "ShadowBeatz!", "TheG18" };
            _playersConfigs = new List<PlayerConfig>{
                new PlayerConfig("Speedy","#4bde6e", "character2"),
                new PlayerConfig("SideArms","#e303fc", "character4"),
                new PlayerConfig("D4","#ccc8c8", "character0"),
                new PlayerConfig("ShadowBeatz!","#071eb3", "character1"),
                new PlayerConfig("TheG18","#e0a80b", "character3")
            };
            _nodes = new List<Node>
            {
                new Node(1, 2),
                new Node(2, 3),
                new Node(3, 4),
                new Node(4, 3),
                new Node(5, 4)
            };
            _random = new Random();
        }
        public GameSetup CreateGame(string playerName)
        {
            var players = AssignRolesToPlayers(playerName);
            var gameSetup = new GameSetup(players, _nodes);
            return gameSetup;
        }

        public List<Player> AssignRolesToPlayers(string playerName)
        {
            var agents = new List<string>(_players);
            var hackers = new List<string>();
            var players = new List<Player>();

            agents.Add(playerName);
            _playersConfigs.Add(new PlayerConfig(playerName, "#e00b1d", "character5"));

            //Assign hacker role to two players(agents)
            for (int i = 0; i < 2; i++)
            {
                AssignHackerRole(agents, hackers);
            }

            agents.ForEach(agentName =>
            {
                var player = new Agent(agentName, GetPlayerConfig(agentName));
                players.Add(player);
            });

            hackers.ForEach(hackerName =>
            {
                var player = new Hacker(hackerName, GetPlayerConfig(hackerName));
                players.Add(player);
            });
            //Assign id for each player
            for (int i = 0; i < players.Count; i++)
            {
                players[i].Id = i;
            }

            return players;
        }

        public PlayerConfig GetPlayerConfig(string playerName) => _playersConfigs.Where(pc => pc.PlayerName == playerName).SingleOrDefault();

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
