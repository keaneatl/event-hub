﻿using EventHub.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventHub.Services
{
    public class EventTypesService : IEventTypesService
    {
        private readonly EventHubussyContext _context;
        public EventTypesService(EventHubussyContext context)
        {
            _context = context;
        }
        public async Task<List<EventType>> GetAllEventTypes()
        {
            var eventTypes = await _context.EventTypes.ToListAsync();

            return eventTypes;
        }
    }
}
