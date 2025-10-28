using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EventPulse_v1.ViewModels
{
    public class CreateEventViewModel : BaseViewModel
    {
        public string EventTitle { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public DateTime Date { get; set; } = DateTime.Today;
        public TimeSpan Time { get; set; } = TimeSpan.FromHours(18);
        public string Location { get; set; } = string.Empty;
        public string Capacity { get; set; } = string.Empty;
        public ObservableCollection<string> VisibilityOptions { get; } = new() { "Public", "Campus-only" };
        public string SelectedVisibility { get; set; } = "Public";

        private bool _isPreviewVisible;
        public bool IsPreviewVisible
        {
            get => _isPreviewVisible;
            set
            {
                _isPreviewVisible = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(PreviewTitle));
                RaisePropertyChanged(nameof(PreviewWhen));
                RaisePropertyChanged(nameof(PreviewLocation));
            }
        }

        public string PreviewTitle => string.IsNullOrEmpty(EventTitle) ? "Event Title" : EventTitle;
        public string PreviewWhen => $"{Date.ToString("ddd, MMM d")} at {Time:hh\\:mm}";
        public string PreviewLocation => string.IsNullOrEmpty(Location) ? "Event Location" : Location;

        public ICommand PreviewCommand { get; }
        public ICommand CreateCommand { get; }

        public CreateEventViewModel()
        {
            PreviewCommand = new RelayCommand(_ =>
            {
                IsPreviewVisible = true;
            });

            CreateCommand = new RelayCommand(_ => CreateEvent());
        }

        void CreateEvent()
        {
            // validation & backend create
            if (string.IsNullOrWhiteSpace(EventTitle))
            {
                // Show error
                return;
            }

            // Create event logic here
            System.Diagnostics.Debug.WriteLine($"Creating event: {EventTitle} at {Location} on {Date}");

            // Reset form
            EventTitle = string.Empty;
            ShortDescription = string.Empty;
            Location = string.Empty;
            Capacity = string.Empty;
            IsPreviewVisible = false;

            RaisePropertyChanged(nameof(EventTitle));
            RaisePropertyChanged(nameof(ShortDescription));
            RaisePropertyChanged(nameof(Location));
            RaisePropertyChanged(nameof(Capacity));
        }
    }
}