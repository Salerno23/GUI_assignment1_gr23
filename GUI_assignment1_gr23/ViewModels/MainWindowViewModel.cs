using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Prism.Mvvm;

namespace GUI_assignment1_gr23
{
    class MainWindowViewModel : BindableBase
    {
        public ObservableCollection<Debtor> DebtorObsList { get; set; }

        public MainWindowViewModel()
        {
            DebtorObsList = new ObservableCollection<Debtor>
            {
                new Debtor("Henrik", 300),
                new Debtor("Michael", 600),
                new Debtor("Poul Ejnar", -300)
            };

            CurrentDeptor = DebtorObsList[_selectedIndex];
        }

        private int _selectedIndex = 0;

        public int SelectedIndex
        {
            get => _selectedIndex;
            set => SetProperty(ref _selectedIndex, value);
        }

        private Debtor _selectedDeptor;

        public Debtor CurrentDeptor
        {
            get => _selectedDeptor;
            set => SetProperty(ref _selectedDeptor, value);
        }
    }
}