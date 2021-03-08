using Microsoft.AspNetCore.Mvc;
using Planner.Data.Event;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Planner.HttpRepositories
{
    /// <summary>
    /// Interface defining the EventHttpRepository.
    /// </summary>
    public interface IEventHttpRepository
    {
        /// <summary>
        /// Get events from the API.
        /// </summary>
        /// <returns>Fetched events.</returns>
        Task<List<EventDto>> GetEvents();
    }
}
