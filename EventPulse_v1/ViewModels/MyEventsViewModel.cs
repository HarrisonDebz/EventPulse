using System.Collections.ObjectModel;
using System.Windows.Input;
using EventPulse_v1.Models;

namespace EventPulse_v1.ViewModels
{
    public class MyResponsesViewModel : BaseViewModel
    {
        public ObservableCollection<EventModel> MyEvents { get; } = new();

        public ICommand UnrsvpCommand { get; }

        public MyResponsesViewModel()
        {
            UnrsvpCommand = new RelayCommand(param => RemoveRsvp(param as EventModel));
            // load sample
            // MyEvents.Add(...)
        }

        void RemoveRsvp(EventModel? ev)
        {
            if (ev == null) return;
            MyEvents.Remove(ev);
            // update backend
        }
    }
}
