using CrewMindnight.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrewMindnight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrewMindnightController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        [HttpGet(Name = "Test")]
        public string Get()
        {
            var x = new Agent("SideArms");
            return x.Name;
        }
    }
}