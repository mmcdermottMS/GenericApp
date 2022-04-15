using GenericApp.Domain.Interfaces;
using GenericApp.Domain.Models;
using Newtonsoft.Json;

namespace GenericWebApp.Services
{
    public class GenericApiService : IGenericApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public GenericApiService(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient();
        }

        public async Task<Person?> GetPerson()
        {
            return JsonConvert.DeserializeObject<Person>(await _httpClient.GetStringAsync($"{_configuration["PersonServiceUri"]}/{new Random().Next(100, 1000)}")) ?? default;
            //return JsonConvert.DeserializeObject<Person>(await httpClient.GetStringAsync($"https://localhost:55443/api/person/{new Random().Next(100, 1000)}")) ?? default;
        }
    }
}
