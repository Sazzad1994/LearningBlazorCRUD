using CRUD.SharedOne.Models;
using CRUD.SharedOne.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {

            _gameService = gameService;
        }
        [HttpPost]

        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            var addedGame = _gameService.AddGame(game);
            return Ok(addedGame);
        }

        [HttpGet]

        public async Task<ActionResult<Game>> GetAllGames()
        {
            var games = _gameService.GetAllGames();
            return Ok(games);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Game>> GetGameById(int id)
        {
            var games = _gameService.GetGameById(id);
            return Ok(games);
        }
        [HttpPut("{id}")]

        public async Task<ActionResult<Game>> EditGame(int id, Game game)
        {
            var UpdateGame = _gameService.EditGame(id, game);
            return Ok(UpdateGame);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<Game>> DeleteGame(int id, Game game)
        {
            var deleteGame = _gameService.DeleteGame(id);
            return Ok(deleteGame);
        }
    }
}
