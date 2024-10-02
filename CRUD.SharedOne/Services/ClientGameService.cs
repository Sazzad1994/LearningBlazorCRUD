using CRUD.SharedOne.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.SharedOne.Services
{
    public class ClientGameService : IGameService
    {
        private readonly HttpClient _httpClient;

        public ClientGameService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Game>> AddGame(Game game1)
        {
            var result = await _httpClient.
                PostAsJsonAsync("/api/game", game1);
            return result.Content.ReadFromJsonAsync<Game>();
        }

        public async Task<bool> DeleteGame(int id)
        {
            var result = await _httpClient.DeleteAsync($"/api/game/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public Task<Game> EditGame(int id, Game game1)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/game/{id}", game1);
            return result.Content.ReadFromJsonAsync<Game>();
        }

        public Task<List<Game>> GetAllGames()
        {
            throw new NotImplementedException();
        }

        public async Task<Game> GetGameById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Game>($"/api/game/{id}");
            return result;
        }
    }
}
