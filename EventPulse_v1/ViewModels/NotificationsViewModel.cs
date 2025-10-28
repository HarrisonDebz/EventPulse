using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EventPulse_v1.ViewModels
{
    public class NotificationsViewModel : BaseViewModel
    {
        private bool _pushEnabled = true;
        public bool PushEnabled
        {
            get => _pushEnabled;
            set
            {
                _pushEnabled = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<string> LeadTimeOptions { get; } = new() { "30 minutes", "1 hour", "24 hours" };

        private string _selectedLeadTime = "1 hour";
        public string SelectedLeadTime
        {
            get => _selectedLeadTime;
            set
            {
                _selectedLeadTime = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<Reminder> UpcomingReminders { get; } = new();

        public NotificationsViewModel()
        {
            // Seed sample reminders
            UpcomingReminders.Add(new Reminder { EventTitle = "Tech Innovators Meetup", WhenSummary = "Tomorrow at 6:00 PM" });
            UpcomingReminders.Add(new Reminder { EventTitle = "Music Night", WhenSummary = "Next week at 7:00 PM" });
        }
    }

    public class Reminder
    {
        public string EventTitle { get; set; } = string.Empty;
        public string WhenSummary { get; set; } = string.Empty;
    }
}