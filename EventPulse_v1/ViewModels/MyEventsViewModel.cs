using System.Collections.ObjectModel;
using System.Windows.Input;
using EventPulse_v1.Models;

namespace EventPulse_v1.ViewModels
{
    public class MyEventsViewModel : BaseViewModel
    {
        public ObservableCollection<EventModel> MyEvents { get; } = new();

        public ICommand UnrsvpCommand { get; }

        public MyEventsViewModel()
        {
            UnrsvpCommand = new RelayCommand(param => RemoveRsvp(param as EventModel));

            // Load sample events
            MyEvents.Add(new EventModel
            {
                Title = "Music Night",
                ShortDescription = "Live performances from campus artists",
                Date = "Nov 10, 2025",
                Location = "Student Center Lawn",
                IsAttending = true,
                AttendeesCount = 120
            });

            MyEvents.Add(new EventModel
            {
                Title = "Career Fair 2025",
                ShortDescription = "Connect with top employers",
                Date = "Nov 20, 2025",
                Location = "University Center",
                IsAttending = true,
                AttendeesCount = 300
            });
        }

        void RemoveRsvp(EventModel? ev)
        {
            if (ev == null) return;
            MyEvents.Remove(ev);
            // update backend
            System.Diagnostics.Debug.WriteLine($"Removed RSVP for: {ev.Title}");
        }
    }
}