// EventModel.cs
using System;
using System.Collections.Generic;

namespace EventPulse_v1.Models
{
    public class EventModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public required string Title { get; set; }
        public required string ShortDescription { get; set; }
        public required string FullDescription { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public required string Location { get; set; }
        public int AttendeesCount { get; set; }
        public bool IsAttending { get; set; }
        public List<UserModel> Attendees { get; set; } = [];
        // Convenience for UI
        public string WhenSummary => Start == default ? "" : $"{Start:ddd, MMM d} • {Start:HH:mm}";
        public string WhenFull => Start == default ? "" : $"{Start:dddd, MMM d yyyy} at {Start:HH:mm}";
    }
}
