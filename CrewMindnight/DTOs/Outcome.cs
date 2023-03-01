namespace CrewMindnight.DTOs
{
    public class Outcome
    {
        public int NumberOfHackersDetected { get; }
        public string Result { get; }

        public Outcome(int numberOfHackerDetected, string result)
        {
            NumberOfHackersDetected = numberOfHackerDetected;
            Result = result;
        }
    }
}
