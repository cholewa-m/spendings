using System.Windows;
using System.Windows.Controls;
using spendings_WPF.model;
using spendings_WPF.controller;

namespace spendings_WPF.view
{
    
    public partial class MainWindow : Window
    {
        private readonly SpendingController spendingController;

        public MainWindow()
        {
            InitializeComponent();

            spendingController = new SpendingController();

            spendingDataGrid.ItemsSource = spendingController.spendings;
        }

        private void addSpendingButton_Click(object sender, RoutedEventArgs e)
        {
            var addSpendingWindow = new AddSpendingWindow();

            // Set proper location of AddWindow
            addSpendingWindow.Left = this.Left;
            addSpendingWindow.Top = this.Top;

            // If window is propersly closed - add spending
            if (addSpendingWindow.ShowDialog() == true)
            {
                spendingController.addSpending(addSpendingWindow.spending);
                totalSpendingsLabel.Text = "Total Spendings: " + spendingController.getTotalSpendings() + "$";
            }
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            Spending selectedSpending = button.DataContext as Spending;

            var addSpendingWindow = new AddSpendingWindow(selectedSpending);

            // Set proper location of AddWindow
            addSpendingWindow.Left = this.Left;
            addSpendingWindow.Top = this.Top;

            // If window is propersly closed - edit spending
            if (addSpendingWindow.ShowDialog() == true)
            {
                selectedSpending.Title = addSpendingWindow.spending.Title;
                selectedSpending.Cost = addSpendingWindow.spending.Cost;
                selectedSpending.Date = addSpendingWindow.spending.Date;

                totalSpendingsLabel.Text = "Total Spendings: " + spendingController.getTotalSpendings() + "$";
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            Spending selectedSpending = button.DataContext as Spending;

            spendingController.removeSpending(selectedSpending);

            totalSpendingsLabel.Text = "Total Spendings: " + spendingController.getTotalSpendings();
        }

    }

}
