using Microsoft.Maui.Controls;
using EventPulse_v1.Models;
using EventPulse_v1.ViewModels;

namespace EventPulse_v1.Views
{
    public partial class EventDetailsPage : ContentPage
    {
        public EventDetailsPage(EventDetailsViewModel selectedEvent)
        {
            InitializeComponent();
            BindingContext = selectedEvent;
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
