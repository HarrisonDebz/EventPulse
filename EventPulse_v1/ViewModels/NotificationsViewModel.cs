using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EventPulse_v1.ViewModels
{
    public class NotificationsViewModel : BaseViewModel
    {
        public bool PushEnabled { get; set; } = true;
        public ObservableCollection<string> LeadTimeOptions { get; } = new() { "30 minutes", "1 hour", "24 hours" };
        public string SelectedLeadTime { get; set; } = "1 hour";
        public ObservableCollection<object> UpcomingReminders { get; } = new(); // create simple reminder DTO

        public NotificationsViewModel()
        {
            // seed reminders if needed
        }
    }
}
