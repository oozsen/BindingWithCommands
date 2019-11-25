using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BindingWithCommands
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel() { }

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
