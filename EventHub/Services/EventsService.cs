using EventHub.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventHub.Services
{
    public class EventsService : IEventsService
    {
        private readonly EventHubussyContext _context;
        public EventsService(EventHubussyContext context)
        {
            _context = context; 
        }

        public async Task<List<Event>> GetAllEvents()
        {
            var events = await _context.Events.ToListAsync();
            return events;
        }
    }
}
