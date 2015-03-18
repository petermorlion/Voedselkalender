using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Voedselkalender.DataModel;

namespace Voedselkalender.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private MonthViewModel _selectedMonth;
        private FoodItemType? _typeFilter;
        private string _selectedMonthName;

        public MainViewModel()
        {
            SelectedMonthName = Months[DateTime.Today.Month - 1];
        }

        public IList<string> Months
        {
            get
            {
                return new List<string>
                {
                    "Januari",
                    "Februari",
                    "Maart",
                    "Mei",
                    "Juni",
                    "Juli",
                    "Augustus",
                    "September",
                    "October",
                    "November",
                    "December"
                };
            }
        }

        public string SelectedMonthName
        {
            get { return SelectedMonth.Name; }
            set
            {
                _selectedMonthName = value;
                SetFoodItems();
            }
        }

        public MonthViewModel SelectedMonth
        {
            get { return _selectedMonth; }
            set
            {
                _selectedMonth = value;
                OnPropertyChanged("SelectedMonth");
            }
        }
        public IList<FoodItemType?> FoodItemTypes
        {
            get { return new List<FoodItemType?> { null, FoodItemType.Fruit, FoodItemType.Vegetable }; }
        }

        public FoodItemType? TypeFilter
        {
            get { return _typeFilter; }
            set
            {
                _typeFilter = value;
                SetFoodItems();
            }
        }

        private void SetFoodItems()
        {
            var foodItems = Food.GetForMonth(Months.IndexOf(_selectedMonthName) + 1).Where(x => _typeFilter.HasValue ? x.Type == _typeFilter : true);
            SelectedMonth = new MonthViewModel(_selectedMonthName, foodItems);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
