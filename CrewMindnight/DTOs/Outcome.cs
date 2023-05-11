namespace CrewMindnight.DTOs
{
    public class Outcome
    {
        public int Node { get; set; }
        public int NumberOfHackersDetected { get; set; }
        public string Result { get; set; }

        public List<string> Participants { get; set; }
    }
}
