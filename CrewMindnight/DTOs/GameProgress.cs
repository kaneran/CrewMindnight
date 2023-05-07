using CrewMindnight.Entities;

namespace CrewMindnight.DTOs
{
    public class GameProgress
    {
        public int Node { get; set; }
        public List<Outcome> Audit { get; set; }
        public List<Player> Participants { get; set; }
    }
}
