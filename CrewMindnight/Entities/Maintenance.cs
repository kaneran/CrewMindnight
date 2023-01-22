namespace CrewMindnight.Entities
{
    public class Maintenance
    {
        public int Node { get; set; }
        public string Outcome { get; set; }
        public List<string> Participants { get; set; }

        public Maintenance(int node, string outcome, List<string> participants)
        {
            Node = node;
            Outcome = outcome;
            Participants = participants;
        }
    }
}
