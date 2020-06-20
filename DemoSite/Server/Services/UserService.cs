using DemoSite.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoSite.Server.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<User>>
                (await _httpClient.GetStreamAsync($"api/user"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<User> GetUserDetails(string userName)
        {
            return await JsonSerializer.DeserializeAsync<User>
                (await _httpClient.GetStreamAsync($"api/user/{userName}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

    }
}
