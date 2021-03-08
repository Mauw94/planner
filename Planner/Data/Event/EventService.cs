using Microsoft.AspNetCore.Mvc;
using Planner.HttpRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planner.Data.Event
{
    /// <summary>
    /// Service that will fetch the events from the Http repository.
    /// </summary>
    public class EventService
    {
        private readonly IEventHttpRepository _eventHttpRepository;

        public EventService(IEventHttpRepository eventHttpRepository)
        {
            _eventHttpRepository = eventHttpRepository;
        }

        /// <summary>
        /// Fetch the events from the HttpRepository.
        /// </summary>
        /// <returns>Fetched events.</returns>
        public async Task<List<EventDto>> FetchEvents()
        {
            return await _eventHttpRepository.GetEvents();
        }
    }
}
