using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DataBusinessLayer;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using UsingEventAggregator.Core;

namespace GUI_assignment1_gr23
{
    class MainWindowViewModel : BindableBase
    {
        IEventAggregator _ea;
        public ObservableCollection<Debtor> DebtorObsList { get; set; }

        public MainWindowViewModel(IEventAggregator ea)
        {
            DebtorObsList = (ObservableCollection<Debtor>)App.DebtDb.GetDebtors();
            CurrentDeptor = DebtorObsList[_selectedIndex];
            _ea = ea;
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

        private ICommand _addDebtorCommand;

        public ICommand AddDebtorCommand => _addDebtorCommand ??
                                            (_addDebtorCommand = new DelegateCommand(AddDebtor));

        private void AddDebtor()
        {
            AddDebtorWindow adw = new AddDebtorWindow();
            if (adw.ShowDialog() == true)
            {
                //Do something with data
            }
        }

        private ICommand _viewDebtorCommand;

        public ICommand ViewDebtorCommand => _viewDebtorCommand ??
                                             (_viewDebtorCommand = new DelegateCommand(ViewDebtor));

        private void ViewDebtor()
        {
            ViewDebtorWindow vdw = new ViewDebtorWindow();
            _ea.GetEvent<CurrentDebtorSentEvent>().Publish(CurrentDeptor);
            if (vdw.ShowDialog() == true)
            {
                //Do something with data

            }
        }
    }
}