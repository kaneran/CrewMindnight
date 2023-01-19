using CrewMindnight.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrewMindnight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrewMindnightController : ControllerBase
    {
        [HttpGet(Name = "Test")]
        public string Get()
        {
            var x = new Agent("SideArms");
            var y = new Hacker("ShadowBeatz");
            return y.PerformAction(1).ToString();
        }
    }
}