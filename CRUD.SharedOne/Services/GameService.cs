using CRUD.Data;
using CRUD.SharedOne.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CRUD.SharedOne.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _dataContext;

        public GameService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Game>> AddGame(Game game1)
        {
            _dataContext.Games.Add(game1);
            await _dataContext.SaveChangesAsync();
            return game1;

        }

        public async Task<bool> DeleteGame(int id)
        {
            var result = await _dataContext.Games.FindAsync(id);
            if (result != null)
            {
                _dataContext.Remove(result);
                _dataContext.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<Game> EditGame(int id, Game game1)
        {
            var result = await _dataContext.Games.FindAsync(id);
            if (result != null)
            {
                result.Name = game1.Name;
                _dataContext.SaveChanges();
                return result;
            }
            throw new Exception("no game found");

        }

        public async Task<List<Game>> GetAllGames()
        {
            await Task.Delay(500);
            var games = await _dataContext.Games.ToListAsync();
            return games;
        }

        public async Task<Game> GetGameById(int id)
        {
            return await _dataContext.Games.FindAsync(id);
        }
    }
}
