namespace CrewMindnight.DTOs
{
    public class Outcome
    {
        public int NumberOfHackersDetected;
        public string Result;

        public Outcome(int numberOfHackerDetected, string result)
        {
            NumberOfHackersDetected = numberOfHackerDetected;
            Result = result;
        }
    }
}
