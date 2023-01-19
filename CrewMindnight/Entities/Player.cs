namespace CrewMindnight.Entities
{
    public class Player
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Player(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
