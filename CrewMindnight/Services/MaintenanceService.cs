using CrewMindnight.DTOs;
using CrewMindnight.Entities;

namespace CrewMindnight.Services
{
    public class MaintenanceService
    {
        public Outcome PerformMaintenance(GameProgress gameProgress)
        {
            var actions = new List<bool>();
            gameProgress.Participants.ForEach((participant) =>
            {
                Player player = participant.Role == "Agent" ? new Agent(participant.Name) : new Hacker(participant.Name);
                var action = player.PerformAction(gameProgress.Node);
                actions.Add(action);
            });
            var numberOfHacksDetected = actions.Where(a => !a).Count();
            var result = numberOfHacksDetected > 0 ? "Hacked" : "Secured";
            return new Outcome(numberOfHacksDetected, result);
        }
    }
}
