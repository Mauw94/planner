using Microsoft.AspNetCore.Mvc;
using Planner.Data.Event;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Planner.HttpRepositories
{
    /// <summary>
    /// Http Repository that handles getting data from the API.
    /// </summary>
    public class EventHttpRepository : IEventHttpRepository
    {
        private readonly HttpClient _httpClient;

        public EventHttpRepository(HttpClient client)
        {
            _httpClient = client;
        }

        /// <summary>
        /// Get events from the API.
        /// </summary>
        /// <returns>Fetched events.</returns>
        public async Task<List<EventDto>> GetEvents()
        {
            var response = await _httpClient.GetAsync("events");
            var content = await response.Content.ReadAsStringAsync();

            var events = JsonSerializer.Deserialize<List<EventDto>>(content,
                new JsonSerializerOptions {PropertyNameCaseInsensitive = true});
            return events;
        }
    }
}