using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventPulse_v1.Models;

namespace EventPulse_v1.Services
{
    public class MockEventService : IEventService
    {
        private readonly List<EventModel> _events;

        public MockEventService()
        {
            _events = new List<EventModel>
            {
                new EventModel
                {
                    Id = "1",
                    Title = "Tech Innovators Meetup",
                    ShortDescription = "Explore the latest in AI and Web3 with top innovators.",
                    Description = "Join us for an evening of networking and innovation with industry leaders in AI and Web3 technologies.",
                    Date = "Nov 4, 2025",
                    Location = "CBU Great Hall",
                    ImageUrl = "https://placehold.co/600x400/222/fff?text=Tech+Meetup",
                    IsRSVPed = false,
                    AttendeesCount = 45,
                    IsAttending = false
                },
                new EventModel
                {
                    Id = "2",
                    Title = "Music Night",
                    ShortDescription = "Join us for live performances from campus artists.",
                    Description = "An evening of amazing music performances by talented students from our campus community.",
                    Date = "Nov 10, 2025",
                    Location = "Student Center Lawn",
                    ImageUrl = "https://placehold.co/600x400/333/fff?text=Music+Night",
                    IsRSVPed = true,
                    AttendeesCount = 120,
                    IsAttending = true
                },
                new EventModel
                {
                    Id = "3",
                    Title = "Hackathon 2025",
                    ShortDescription = "48 hours of coding, pizza, and prizes.",
                    Description = "Annual campus hackathon with workshops, mentors, and great prizes for the best projects.",
                    Date = "Dec 2, 2025",
                    Location = "Innovation Hub",
                    ImageUrl = "https://placehold.co/600x400/111/fff?text=Hackathon",
                    IsRSVPed = false,
                    AttendeesCount = 200,
                    IsAttending = false
                }
            };
        }

        public async Task<IEnumerable<EventModel>> GetEventsAsync()
        {
            await Task.Delay(100); // Simulate network latency
            return _events;
        }

        public async Task<EventModel?> GetEventAsync(string id)
        {
            await Task.Delay(100);
            return _events.FirstOrDefault(e => e.Id == id);
        }
    }
}
