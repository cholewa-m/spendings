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
using System.Windows.Navigation;
using System.Windows.Shapes;

using spendings_WPF.model;
using spendings_WPF.controller;

namespace spendings_WPF
{
    
    public partial class MainWindow : Window
    {
        private readonly SpendingController spendingController;

        public MainWindow()
        {
            InitializeComponent();

            spendingController = new SpendingController();

            spendingsListView.ItemsSource = spendingController.Spendings;
        }

        private void addSpendingButton_Click(object sender, RoutedEventArgs e)
        {
            var addSpendingWindow = new AddSpendingWindow();

            // Ustaw położenie nowego okna na środek okna głównego.
            addSpendingWindow.Left = this.Left + (this.Width - addSpendingWindow.Width) / 2;
            addSpendingWindow.Top = this.Top + (this.Height - addSpendingWindow.Height) / 2;

            if (addSpendingWindow.ShowDialog() == true)
            {
                spendingController.AddSpending(addSpendingWindow.spending);
                totalSpendingsLabel.Text = "Total Spendings: " + spendingController.GetTotalSpendings();
            }
        }



        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            // Odnajdujemy przycisk, który został kliknięty.
            Button button = sender as Button;

            // Jeżeli nie jest to przycisk, zakończ działanie metody.
            if (button == null)
                return;

            // Wykorzystujemy DataContext przycisku, aby znaleźć powiązany wydatek.
            Spending selectedSpending = button.DataContext as Spending;

            // Jeżeli nie ma powiązanego wydatku, zakończ działanie metody.
            if (selectedSpending == null)
                return;

            // Wyświetl okno edycji z wybranym wydatkiem.
            var addSpendingWindow = new AddSpendingWindow(selectedSpending);

            // Ustaw położenie nowego okna na środek okna głównego.
            addSpendingWindow.Left = this.Left + (this.Width - addSpendingWindow.Width) / 2;
            addSpendingWindow.Top = this.Top + (this.Height - addSpendingWindow.Height) / 2;

            if (addSpendingWindow.ShowDialog() == true)
            {
                selectedSpending.Title = addSpendingWindow.spending.Title;
                selectedSpending.Cost = addSpendingWindow.spending.Cost;
                selectedSpending.Date = addSpendingWindow.spending.Date;

                totalSpendingsLabel.Text = "Total Spendings: " + spendingController.GetTotalSpendings();
            }
        }


        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Odnajdujemy przycisk, który został kliknięty.
            Button button = sender as Button;

            // Jeżeli nie jest to przycisk, zakończ działanie metody.
            if (button == null)
                return;

            // Wykorzystujemy DataContext przycisku, aby znaleźć powiązany wydatek.
            Spending selectedSpending = button.DataContext as Spending;

            // Jeżeli nie ma powiązanego wydatku, zakończ działanie metody.
            if (selectedSpending == null)
                return;

            // Usuń wybrany wydatek.
            spendingController.RemoveSpending(selectedSpending);

            // Aktualizuj sumę wydatków.
            totalSpendingsLabel.Text = "Total Spendings: " + spendingController.GetTotalSpendings();
        }


    }
}
