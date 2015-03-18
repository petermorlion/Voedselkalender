using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Voedselkalender.DataModel;

namespace Voedselkalender.ViewModels
{
    public class FoodItemViewModel : INotifyPropertyChanged
    {
        public FoodItemViewModel()
        {
        }

        public FoodItemViewModel(FoodItem foodItem)
        {
            // TODO: localization
            Name = foodItem.Name;
            WikipediaKey = foodItem.WikipediaKey;
            Key = foodItem.Name;
            Type = foodItem.Type;
        }

        public string Name { get; set; }

        public string Key { get; private set; }

        public string WikipediaKey { get; private set; }

        public FoodItemType Type { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
