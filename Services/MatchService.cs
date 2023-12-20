using System.Net.Http.Json;
using WorldCupResultsWithBlazorWASM.Dtos;

namespace WorldCupResultsWithBlazorWASM.Services
{
    public class MatchService : IMatchService
    {
        private readonly HttpClient _http;
        private readonly string _baseUrl = "https://api.football-data.org/v4";


        public MatchService(HttpClient http)
        {
            _http = http;
            _http.DefaultRequestHeaders.Add("X-Auth-Token", "a2b54c0e7cba4dd2a0a781bf8a26b134") ;
        }

        public async Task<StandingsResponseDto?> GetStandings()
        {
            return await _http.GetFromJsonAsync<StandingsResponseDto?>($"{_baseUrl}/competitions/WC/standings");
        }

        public async Task<MatchesResponseDto?> GetTodayMatches()
        {
            var todayDate = "2022-11-24"; //DateTime.Today.ToString("yyyy-MM-dd");
            return await _http.GetFromJsonAsync<MatchesResponseDto?>($"{_baseUrl}/competitions/WC/matches?dateFrom={todayDate}&dateTo={todayDate}");
        }
    }
}
