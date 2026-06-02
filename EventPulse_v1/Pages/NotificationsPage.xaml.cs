using Microsoft.Maui.Controls;
using EventPulse_v1.ViewModels;

namespace EventPulse_v1.Pages
{
    public partial class NotificationsPage : ContentPage
    {
        public NotificationsPage(NotificationsViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}