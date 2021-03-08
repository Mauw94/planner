using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Planner.API.Models;
using Planner.API.Models.DTOs;
using Planner.API.Repositories;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Planner.API.Controllers
{
    /// <summary>
    /// Api controller to handle the event data.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        private readonly IRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public EventsController(IRepository<Event> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all events.
        /// </summary>
        /// <returns>List of events.</returns>
        [HttpGet]
        public async Task<List<EventDto>> GetAll()
        {
            var events = await _eventRepository.GetAll().ToListAsync();
            return _mapper.Map<List<EventDto>>(events);
        }

        /// <summary>
        /// Add a new event.
        /// </summary>
        /// <param name="plannedEvent">Event to add.</param>
        [HttpPost]
        public async Task Add(EventDto plannedEvent)
        {
            var mappedEvent = _mapper.Map<Event>(plannedEvent);
            await _eventRepository.AddAsync(mappedEvent);
        }
    }
}