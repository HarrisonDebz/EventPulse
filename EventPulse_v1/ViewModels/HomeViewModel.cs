using System.Collections.ObjectModel;
using EventPulse_v1.Models;

namespace EventPulse_v1.ViewModels
{
    public class Event
    {
        public string Description { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsRSVPed { get; set; }

        public ObservableCollection<Event> Events { get; set; }

        public Event()
        {
            Events = new ObservableCollection<Event>
            {
                new Event
                {
                    Title = "Tech Innovators Meetup",
                    Description = "Explore the latest in AI and Web3 with top innovators.",
                    Date = "Nov 4, 2025",
                    Location = "CBU Great Hall",
                    ImageUrl = "https://placehold.co/600x400/222/fff?text=Tech+Meetup",
                    IsRSVPed = false
                },
                new Event
                {
                    Title = "Music Night",
                    Description = "Join us for live performances from campus artists.",
                    Date = "Nov 10, 2025",
                    Location = "Student Center Lawn",
                    ImageUrl = "https://placehold.co/600x400/333/fff?text=Music+Night",
                    IsRSVPed = true
                },
                new Event
                {
                    Title = "Hackathon 2025",
                    Description = "48 hours of coding, pizza, and prizes.",
                    Date = "Dec 2, 2025",
                    Location = "Innovation Hub",
                    ImageUrl = "https://placehold.co/600x400/111/fff?text=Hackathon",
                    IsRSVPed = false
                }
            };
        }
    }
}
