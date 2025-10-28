using System.Collections.ObjectModel;

namespace EventPulse_v1.Models
{
    public class EventModel
    {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string FullDescription { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Date { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsRSVPed { get; set; }
        public bool IsAttending { get; set; }
        public int AttendeesCount { get; set; }
        
        // Computed properties for data binding
        public string WhenSummary => $"{Date} at {Location}";
        public string WhenFull => $"{Date} • {Location}";
        
        // Attendees collection
        public ObservableCollection<Attendee> Attendees { get; set; } = new ObservableCollection<Attendee>();
    }

    public class Attendee
    {
        public string Name { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = string.Empty;
    }
}