using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

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
            costTextBox.Text = spending.Cost.ToString(CultureInfo.InvariantCulture);
            datePicker.SelectedDate = spending.Date;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string title = titleTextBox.Text.Trim();
            string costText = costTextBox.Text.Trim();
            DateTime? date = datePicker.SelectedDate;

            // Validating Title
            if (string.IsNullOrEmpty(title) || title.Length > 500)
            {
                MessageBox.Show("Title cannot be empty, whitespace, or more than 500 characters!");
                return;
            }

            // Validating Cost
            if (!decimal.TryParse(costText, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal cost))
            {
                MessageBox.Show("Cost must be a postive decimal number!");
                return;
            }

            // Validating Date
            if (!date.HasValue)
            {
                MessageBox.Show("Please select a date!");
                return;
            }

            spending = new Spending
            {
                Title = title,
                Cost = cost,
                Date = date.Value
            };

            DialogResult = true;
        }
    }
}
