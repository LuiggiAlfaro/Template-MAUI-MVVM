using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer.UI.ViewModels
{
  internal class MainViewModel : INotifyPropertyChanged
  {
        private int _count = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CounterCommand { get; }

        public string CounterText => _count == 1 ? $"Clicked {_count} time" : $"Clicked {_count} times";

        public MainViewModel()
        {
            CounterCommand = new Command(OnCounterClicked);
        }

        private void OnCounterClicked()
        {
            _count++;
            OnPropertyChanged(nameof(CounterText)); // Notify UI to update the text
            SemanticScreenReader.Announce(CounterText); // Accessibility feature
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
