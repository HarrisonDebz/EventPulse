using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EventPulse_v1.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string name = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        bool isBusy;
        public bool IsBusy { get => isBusy; set { isBusy = value; RaisePropertyChanged(); } }
    }
}