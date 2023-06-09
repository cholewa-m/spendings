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

            if (addSpendingWindow.ShowDialog() == true)
            {
                spendingController.AddSpending(addSpendingWindow.spending);
                
              
                totalSpendingsLabel.Content = "Total Spendings: " + spendingController.GetTotalSpendings();
            }
        }


        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Spending selectedSpending = (Spending)spendingsListView.SelectedItem;

            if (selectedSpending != null)
            {
                var addSpendingWindow = new AddSpendingWindow(selectedSpending);

                if (addSpendingWindow.ShowDialog() == true)
                {
                    selectedSpending.Title = addSpendingWindow.spending.Title;
                    selectedSpending.Cost = addSpendingWindow.spending.Cost;
                    selectedSpending.Date = addSpendingWindow.spending.Date;


                    totalSpendingsLabel.Content = "Total Spendings: " + spendingController.GetTotalSpendings();
                }
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Pobieramy wybrany wydatek do usunięcia.
            Spending selectedSpending = (Spending)spendingsListView.SelectedItem;

            if (selectedSpending != null)
            {
                spendingController.RemoveSpending(selectedSpending);


                // Aktualizujemy sumę wydatków.
                totalSpendingsLabel.Content = "Total Spendings: " + spendingController.GetTotalSpendings();
            }
        }

    }
}
