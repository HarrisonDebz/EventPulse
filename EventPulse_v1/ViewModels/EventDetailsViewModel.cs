using System.Windows.Input;
using EventPulse_v1.Models;

namespace EventPulse_v1.ViewModels
{
    public class EventDetailsViewModel : BaseViewModel
    {
        private EventModel _event = new EventModel();
<<<<<<< HEAD
        public EventModel Event
        {
            get => _event;
            set
            {
                _event = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(RsvpButtonText));
                RaisePropertyChanged(nameof(WhenFull));
            }
=======
        public EventModel Event 
        { 
            get => _event; 
            set 
            { 
                _event = value; 
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(RsvpButtonText));
                RaisePropertyChanged(nameof(WhenFull));
            } 
>>>>>>> e15dbea63a55850cd555d255db5fcd9cb6ed9f2f
        }

        public ICommand ToggleRsvpCommand { get; }
        public ICommand ShareCommand { get; }

        public string RsvpButtonText => Event?.IsAttending == true ? "Un-RSVP" : "RSVP";
        public string WhenFull => Event != null ? $"{Event.Date} • {Event.Location}" : string.Empty;

        public EventDetailsViewModel()
        {
            // Initialize with a sample event
            Event = new EventModel
            {
                Title = "Sample Event",
                ShortDescription = "This is a sample event description",
                FullDescription = "This is the full description of the sample event with all the details you need to know about this amazing event.",
                Date = "Nov 15, 2025",
                Location = "Sample Location",
                IsAttending = false,
                AttendeesCount = 25
            };

            // Add sample attendees
            Event.Attendees.Add(new Attendee { Name = "John Doe", AvatarUrl = "https://placehold.co/40x40/666/fff?text=JD" });
            Event.Attendees.Add(new Attendee { Name = "Jane Smith", AvatarUrl = "https://placehold.co/40x40/666/fff?text=JS" });
            Event.Attendees.Add(new Attendee { Name = "Mike Johnson", AvatarUrl = "https://placehold.co/40x40/666/fff?text=MJ" });

            ToggleRsvpCommand = new RelayCommand(_ => ToggleRsvp());
            ShareCommand = new RelayCommand(_ => Share());
        }

        void ToggleRsvp()
        {
            if (Event == null) return;
<<<<<<< HEAD

=======
            
>>>>>>> e15dbea63a55850cd555d255db5fcd9cb6ed9f2f
            Event.IsAttending = !Event.IsAttending;
            if (Event.IsAttending)
                Event.AttendeesCount++;
            else if (Event.AttendeesCount > 0)
                Event.AttendeesCount--;
<<<<<<< HEAD

=======
                
>>>>>>> e15dbea63a55850cd555d255db5fcd9cb6ed9f2f
            RaisePropertyChanged(nameof(RsvpButtonText));
        }

        void Share()
        {
            // integrate share
            System.Diagnostics.Debug.WriteLine($"Sharing event: {Event.Title}");
        }
    }
}