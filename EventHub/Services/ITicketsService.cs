using EventHub.Entities;

namespace EventHub.Services
{
    public interface ITicketsService
    {
        Task<List<Ticket>> GetAllTickets();
        Task<List<Ticket>> GetEventTickets(string eventId);
    }
}
