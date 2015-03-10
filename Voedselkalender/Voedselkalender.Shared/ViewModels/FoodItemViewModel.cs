using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Voedselkalender.ViewModels
{
    public class FoodItemViewModel : INotifyPropertyChanged
    {
        public FoodItemViewModel()
        {
        }

        public FoodItemViewModel(string name)
        {
            // TODO: localization
            Name = name;
            Key = name;
        }

        public string Name { get; set; }

        public string Key { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
