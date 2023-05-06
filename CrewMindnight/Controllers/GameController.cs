using CrewMindnight.DTOs;
using CrewMindnight.Entities;
using CrewMindnight.Services;
using Microsoft.AspNetCore.Mvc;

namespace CrewMindnight.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private GameService _gameService;
        public GameController()
        {
            _gameService = new GameService();
        }
        [HttpGet(Name = "Test")]
        public GameSetup CreateGame([FromQuery]string playerName)
        {
            var gameSetup = _gameService.CreateGame(playerName);
            return gameSetup;
        }
    }
}