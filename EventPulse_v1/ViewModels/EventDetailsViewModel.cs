using System.Windows.Input;
using EventPulse_v1.Models;

namespace EventPulse_v1.ViewModels
{
    public class EventDetailsViewModel : BaseViewModel
    {
        public EventModel Event { get; set; } = new EventModel();
        public ICommand ToggleRsvpCommand { get; }
        public ICommand ShareCommand { get; }

        public string RsvpButtonText => Event.IsAttending ? "Un-RSVP" : "RSVP";

        public EventDetailsViewModel()
        {
            ToggleRsvpCommand = new RelayCommand(_ => ToggleRsvp());
            ShareCommand = new RelayCommand(_ => Share());
        }

        void ToggleRsvp()
        {
            Event.IsAttending = !Event.IsAttending;
            // update backend
            RaisePropertyChanged(nameof(RsvpButtonText));
        }

        void Share()
        {
            // integrate share
        }
    }
}
