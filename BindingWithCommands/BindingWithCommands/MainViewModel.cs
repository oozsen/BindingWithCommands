using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BindingWithCommands
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            IncreaseCommand = new Command(IncreaseCount);            
        }

        public ICommand IncreaseCommand { get; } 

        int count = 0;
        public string DisplayCount => $"You clicked {count} time(s).";


        void IncreaseCount()
        {
            count++;
            OnPropertyChanged(nameof(DisplayCount));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
