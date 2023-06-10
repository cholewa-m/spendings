using System;
using System.ComponentModel;

namespace spendings_WPF.model
{
    public class Spending : INotifyPropertyChanged
    {
        private string title;
        private decimal cost;
        private DateTime date;

        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        public decimal Cost
        {
            get { return cost; }
            set
            {
                if (cost != value)
                {
                    cost = value;
                    OnPropertyChanged("Cost");
                }
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged("Date");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
