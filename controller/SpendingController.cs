using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections.ObjectModel;
using spendings_WPF.model;

namespace spendings_WPF.controller
{
    public class SpendingController
    {
        // Zmieniamy typ listy na ObservableCollection
        public ObservableCollection<Spending> Spendings { get; set; } = new ObservableCollection<Spending>();


        public void AddSpending(Spending spending)
        {
            Spendings.Add(spending);
            SortSpendings();
        }

        public void RemoveSpending(Spending spending)
        {
            Spendings.Remove(spending);
            SortSpendings();
        }

        public void EditSpending(Spending oldSpending, Spending newSpending)
        {
            int index = Spendings.IndexOf(oldSpending);
            if (index != -1)
            {
                Spendings[index] = newSpending;
            }
        }

        public decimal GetTotalSpendings()  //po dacie?
        {
            return Spendings.Sum(s => s.Cost);
        }

        private void SortSpendings()
        {
            var sortedSpendings = Spendings.OrderBy(s => s.Date).ToList();

            Spendings.Clear();

            foreach (var spending in sortedSpendings)
            {
                Spendings.Add(spending);
            }
        }



    }


}
