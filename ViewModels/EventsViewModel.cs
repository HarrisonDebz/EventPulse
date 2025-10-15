using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;


public partial class EventsViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<EventModel> events = new();


    public EventsViewModel()
    {
        Events.Add(new EventModel { Title = "Hackathon 2025", Description = "24hr coding challenge", Date = DateTime.Now.AddDays(5), Venue = "CBU Auditorium" });
    }
}