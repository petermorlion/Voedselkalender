using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Voedselkalender.DataModel;

namespace Voedselkalender.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private MonthViewModel _selectedMonth;

        public MainViewModel()
        {
            var currentMonth = Months[DateTime.Today.Month - 1];
            SelectedMonth = new MonthViewModel(currentMonth, Food.GetForMonth(DateTime.Today.Month));
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
                SelectedMonth = new MonthViewModel(value, Food.GetForMonth(Months.IndexOf(value) + 1));
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
