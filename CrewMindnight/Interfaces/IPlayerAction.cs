using CrewMindnight.DTOs;

namespace CrewMindnight.Interfaces
{
    public interface IPlayerAction
    {
        public bool PerformAction(GameProgress gameProgress);
    }
}
