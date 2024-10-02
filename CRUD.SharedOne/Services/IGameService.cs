using CRUD.SharedOne.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD.SharedOne.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();

        Task<Game> GetGameById(int id);
        Task<List<Game>> AddGame(Game game1);
        Task<Game> EditGame(int id, Game game1);
        Task<bool> DeleteGame(int id);
    }
}
