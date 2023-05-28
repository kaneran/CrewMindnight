using CrewMindnight.Entities;

namespace CrewMindnight.DTOs
{
    public record GameSetup
    {
        public List<Player> Players { get; set; }
        public List<Node> Nodes { get; set; }

        public GameSetup(List<Player> players, List<Node> nodes)
        {
            Players = players;
            Nodes = nodes;
        }
    }
}
