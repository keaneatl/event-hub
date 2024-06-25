using EventHub.Entities;

namespace EventHub.Services
{
    public interface IEventsService
    {
        Task<List<Event>> GetAllEvents();
    }
}
