using Microsoft.Maui.Controls;
using EventPulse_v1.ViewModels;

namespace EventPulse_v1.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}

namespace EventPulse_v1.ViewModels
{
    // Minimal ViewModel so the project compiles; expand with properties/commands as needed.
    public class HomeViewModel
    {
    }
}
