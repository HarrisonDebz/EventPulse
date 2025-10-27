using Microsoft.Maui.Controls;
using EventPulse_v1.ViewModels;

namespace EventPulse_v1.Views
{
    public partial class MyEventsPage : ContentPage
    {
        public MyEventsPage()
        {
            InitializeComponent();
            BindingContext = new MyEventsViewModel();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
