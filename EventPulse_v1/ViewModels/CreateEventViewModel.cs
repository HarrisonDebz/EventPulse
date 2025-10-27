using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EventPulse_v1.ViewModels
{
    public class CreateEventViewModel : BaseViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Today;
        public TimeSpan Time { get; set; } = TimeSpan.FromHours(18);
        public string Location { get; set; } = string.Empty;
        public string Capacity { get; set; } = string.Empty;
        public ObservableCollection<string> VisibilityOptions { get; } = new() { "Public", "Campus-only" };
        public string SelectedVisibility { get; set; } = "Public";
        public bool IsPreviewVisible { get; set; }
        public string PreviewTitle => Title;
        public string PreviewWhen => $"{Date.ToString("ddd, MMM d")} {Time}";
        public string PreviewLocation => Location;

        public ICommand PreviewCommand { get; }
        public ICommand CreateCommand { get; }

        public CreateEventViewModel()
        {
            PreviewCommand = new RelayCommand(_ => IsPreviewVisible = true);
            CreateCommand = new RelayCommand(_ => CreateEvent());
        }

        void CreateEvent()
        {
            // validation & backend create
        }
    }
}
