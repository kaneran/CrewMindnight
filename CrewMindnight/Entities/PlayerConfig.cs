namespace CrewMindnight.Entities
{
    public class PlayerConfig
    {
        public string PlayerName { get; set; }
        public string PlayerTextColour { get; set; }
        public string PlayerCharacterFileName { get; set; }
        public PlayerConfig(string playerName, string playerTextColour, string playerCharacterFileName)
        {
            PlayerName = playerName;
            PlayerTextColour = playerTextColour;
            PlayerCharacterFileName = playerCharacterFileName;
        }
    }
}
