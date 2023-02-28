using CrewMindnight.Entities;

namespace CrewMindnight.DTOs
{
    public class GameProgress
    {
        public int Node { get; set; }
        public List<Maintenance> Audit { get; set; }
        public List<Player> Participants { get; set; }
    }
}
