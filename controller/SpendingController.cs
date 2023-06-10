using System;
using System.Linq;
using System.Collections.ObjectModel;
using spendings_WPF.model;


namespace spendings_WPF.controller
{
    public class SpendingController
    {        
        //TODO UI can ract to changes
        public ObservableCollection<Spending> spendings = new ObservableCollection<Spending>();

        public void addSpending(Spending spending)
        {
            spendings.Add(spending);
            sortSpendings();
        }

        public void removeSpending(Spending spending)
        {
            spendings.Remove(spending);
            sortSpendings();
        }

        public void editSpending(Spending oldSpending, Spending newSpending)
        {
            int index = spendings.IndexOf(oldSpending);
            if (index != -1)
                spendings[index] = newSpending;
        }

        public decimal getTotalSpendings()
        {
            return spendings.Sum(s => s.Cost);
        }

        private void sortSpendings()
        {
            var sortedSpendings = spendings.OrderBy(s => s.Date).ToList();

            spendings.Clear();

            foreach (Spending spending in sortedSpendings)
                spendings.Add(spending);
        }

    }

}

