using System.Collections.ObjectModel;
using System.Windows.Input;
using EventPulse_v1.Models;

namespace EventPulse_v1.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<EventModel> Events { get; } = new();
        public string SearchQuery { get; set; }
        public EventModel SelectedEvent { get; set; }

        public ICommand OpenFiltersCommand { get; }
        public ICommand RsvpCommand { get; }
        public ICommand NavigateCreateCommand { get; }

        public MainViewModel()
        {
            OpenFiltersCommand = new RelayCommand(_ => OpenFilters());
            RsvpCommand = new RelayCommand(param => ToggleRsvp(param as EventModel));
            NavigateCreateCommand = new RelayCommand(_ => Shell.Current.GoToAsync("//Create"));

            // sample seed
            Events.Add(new EventModel { Id="1", Title="Welcome Mixer", ShortDescription="Meet new people", WhenSummary="Fri, Oct 31 • 18:00", AttendeesCount=12 });
            Events.Add(new EventModel { Id="2", Title="AI Workshop", ShortDescription="Intro to ML", WhenSummary="Mon, Nov 3 • 15:00", AttendeesCount=34 });
        }

        void OpenFilters()
        {
            // show filter modal or navigate
        }

        void ToggleRsvp(EventModel? ev)
        {
            if (ev == null) return;
            // optimistic UI - toggle locally; persist to backend later
            ev.IsAttending = !ev.IsAttending;
            ev.AttendeesCount += ev.IsAttending ? 1 : -1;
        }
    }
}
