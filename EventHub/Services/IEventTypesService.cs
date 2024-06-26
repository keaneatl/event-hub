using EventHub.Entities;

namespace EventHub.Services
{
    public interface IEventTypesService
    {
        public Task<List<EventType>> GetAllEventTypes();
    }
}
