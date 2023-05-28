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
                Player player = participant.Role is "Agent" ? new Agent(participant.Name) : new Hacker(participant.Name);
                var action = player.PerformAction(gameProgress);
                actions.Add(action);
            });
            var numberOfHacksDetected = actions.Where(a => !a).Count();
            var result = numberOfHacksDetected > 0 ? "Hacked" : "Secured";
            return new Outcome() {NumberOfHackersDetected= numberOfHacksDetected, Result = result, Node = gameProgress.Node, Participants = gameProgress.Participants.Select(p => p.Name).ToList() };
        }
    }
}
