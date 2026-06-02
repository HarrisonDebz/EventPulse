using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace EventPulse_v1.ViewModels
{
    public partial class NotificationsViewModel : BaseViewModel
    {
        [ObservableProperty]
        bool pushEnabled = true;

        public ObservableCollection<string> LeadTimeOptions { get; } = new() { "30 minutes", "1 hour", "24 hours" };

        [ObservableProperty]
        string selectedLeadTime = "1 hour";

        public ObservableCollection<Reminder> UpcomingReminders { get; } = new();

        public NotificationsViewModel()
        {
            Title = "Notifications";
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