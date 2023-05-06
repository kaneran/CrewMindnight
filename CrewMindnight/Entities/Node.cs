namespace CrewMindnight.Entities
{
    public class Node
    {
        public int Id { get; set; }
        public int NumberOfParticipantsRequired { get; set; }

        public Node(int id, int numberOfParticipantsRequired)
        {
            Id = id;
            NumberOfParticipantsRequired = numberOfParticipantsRequired;
        }
    }
}
