namespace CrewMindnight.DTOs
{
    public class Outcome
    {
        public int Node { get; set; }
        public int NumberOfHackersDetected { get; }
        public string Result { get; }

        public List<string> Participants { get; set; }


        public Outcome(int numberOfHackerDetected, string result, int node, List<string> participants)
        {
            NumberOfHackersDetected = numberOfHackerDetected;
            Result = result;
            Node = node;
            Participants = participants;
        }
    }
}
