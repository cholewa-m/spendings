using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using spendings_WPF.model;

namespace spendings_WPF
{
    public partial class AddSpendingWindow : Window
    {
        public Spending spending { get; private set; }

        public AddSpendingWindow()
        {
            InitializeComponent();
        }

        public AddSpendingWindow(Spending spending)
        {
            InitializeComponent();

            this.spending = spending;

            titleTextBox.Text = spending.Title;
            costTextBox.Text = spending.Cost.ToString();
            datePicker.SelectedDate = spending.Date;
        }


        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            spending = new Spending
            {
                Title = titleTextBox.Text,
                Cost = decimal.Parse(costTextBox.Text), // TODO validation
                Date = datePicker.SelectedDate.Value // TODO validation
            };

            DialogResult = true;
        }
    }
}
