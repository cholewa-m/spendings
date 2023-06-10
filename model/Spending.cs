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
            set { SetProperty(ref title, value); }
        }

        public decimal Cost
        {
            get { return cost; }
            set { SetProperty(ref cost, value); }
        }

        public DateTime Date
        {
            get { return date; }
            set { SetProperty(ref date, value); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void SetProperty<T>(ref T field, T value, string propertyName = null)
        {
            if (Equals(field, value))
                return;

            field = value;
            OnPropertyChanged(propertyName);
        }

        // Subscribing UI elements will be notified
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
