using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI_assignment1_gr23
{
    public class DebtorModel : INotifyPropertyChanged
    {
        private readonly Debtor _debtorHenrik = new Debtor("Henrik", 300);
        private readonly Debtor _debtorMichael = new Debtor("Michael", 600);

        public DebtorModel()
        {
            DebtorObsList = new ObservableCollection<Debtor>{_debtorHenrik, _debtorMichael};
            CurrentDeptor = DebtorObsList[_selectedIndex];
        }

        public ObservableCollection<Debtor> DebtorObsList { get; set; }

        private int _selectedIndex = 0;

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if (_selectedIndex != value)
                {
                    _selectedIndex = value;
                    Notify();
                }
            }
        }

        private Debtor _selectedDeptor;

        public Debtor CurrentDeptor
        {
            get => _selectedDeptor;
            set
            {
                if (_selectedDeptor != value)
                {
                    _selectedDeptor = value;
                    Notify();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
