using Microsoft.Maui.Controls;
using EventPulse_v1.ViewModels;

namespace EventPulse_v1.Pages
{
    public partial class EventDetailsPage : ContentPage
    {
        public EventDetailsPage(EventDetailsViewModel selectedEvent)
        {
            InitializeComponent();
            BindingContext = selectedEvent;
        }
    }
}
