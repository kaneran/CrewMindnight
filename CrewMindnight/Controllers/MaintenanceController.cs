using CrewMindnight.DTOs;
using CrewMindnight.Entities;
using CrewMindnight.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrewMindnight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaintenanceController : ControllerBase
    {

        [HttpGet(Name = "Maintenance")]
        public List<Player> PerformMaintenance([FromBody] GameProgress gameProgress)
        {
            return null;
        }
    }
}