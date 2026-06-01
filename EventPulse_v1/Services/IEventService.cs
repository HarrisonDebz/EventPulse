using System.Collections.Generic;
using System.Threading.Tasks;
using EventPulse_v1.Models;

namespace EventPulse_v1.Services
{
    public interface IEventService
    {
        Task<IEnumerable<EventModel>> GetEventsAsync();
        Task<EventModel?> GetEventAsync(string id);
    }
}
