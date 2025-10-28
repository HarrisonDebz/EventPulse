using System.Collections.ObjectModel;
using System.Windows.Input;
using EventPulse_v1.Models;

namespace EventPulse_v1.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string SearchQuery { get; set; } = string.Empty;
        public ObservableCollection<EventModel> Events { get; set; }
        public EventModel? SelectedEvent { get; set; }

        public ICommand OpenFiltersCommand { get; }
        public ICommand RsvpCommand { get; }
        public ICommand NavigateCreateCommand { get; }

        public MainViewModel()
        {
            Events = new ObservableCollection<EventModel>
            {
                new EventModel
                {
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

            // Initialize commands
            RsvpCommand = new RelayCommand(param =>
            {
                if (param is EventModel eventItem)
                {
                    eventItem.IsRSVPed = !eventItem.IsRSVPed;
                    eventItem.IsAttending = eventItem.IsRSVPed;
                    if (eventItem.IsRSVPed)
                        eventItem.AttendeesCount++;
                    else if (eventItem.AttendeesCount > 0)
                        eventItem.AttendeesCount--;
                }
            });

            NavigateCreateCommand = new RelayCommand(_ =>
            {
                // Navigation logic here - will be implemented later
                System.Diagnostics.Debug.WriteLine("Navigate to Create Event");
            });

            OpenFiltersCommand = new RelayCommand(_ =>
            {
                // Filter logic here - will be implemented later
                System.Diagnostics.Debug.WriteLine("Open Filters");
            });
        }
    }
}