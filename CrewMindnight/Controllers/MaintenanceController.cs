using CrewMindnight.DTOs;
using CrewMindnight.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrewMindnight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MaintenanceController : ControllerBase
    {
        private MaintenanceService _maintenanceService;

        public MaintenanceController()
        {
            _maintenanceService = new MaintenanceService();
        }

        [HttpGet(Name = "Maintenance")]
        public Outcome PerformMaintenance([FromBody] GameProgress gameProgress)
        {
            return _maintenanceService.PerformMaintenance(gameProgress);
        }
    }
}