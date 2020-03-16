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
using GUI_assignment1_gr23.Views;
using Prism.Commands;
using Prism.Mvvm;

namespace GUI_assignment1_gr23.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private ObservableCollection<Debtor> _debtorObsList;

        public ObservableCollection<Debtor> DebtorObsList
        {
            get => _debtorObsList;
            set => SetProperty(ref _debtorObsList, value);
        }

        public MainWindowViewModel()
        {
            DebtorObsList = (ObservableCollection<Debtor>) App.DebtDb.GetDebtors();
            CurrentDebtor = DebtorObsList[_selectedIndex];
        }

        private int _selectedIndex = 0;

        public int SelectedIndex
        {
            get => _selectedIndex;
            set => SetProperty(ref _selectedIndex, value);
        }

        private Debtor _selectedDebtor;

        public Debtor CurrentDebtor
        {
            get => _selectedDebtor;
            set => SetProperty(ref _selectedDebtor, value);
        }

        private ICommand _addDebtorCommand;

        public ICommand AddDebtorCommand => _addDebtorCommand ??
                                            (_addDebtorCommand = new DelegateCommand(AddDebtor));

        private void AddDebtor()
        {
            AddDebtorWindow adw = new AddDebtorWindow();
            adw.Closed += AdwOnClosed;

            if (adw.ShowDialog() == true)
            {
                //Do something with data
            }
        }

        private void AdwOnClosed(object sender, EventArgs e)
        {
            DebtorObsList = (ObservableCollection<Debtor>) App.DebtDb.GetDebtors();
        }

        private ICommand _viewDebtorCommand;

        public ICommand ViewDebtorCommand => _viewDebtorCommand ??
                                             (_viewDebtorCommand = new DelegateCommand(ViewDebtor));

        private void ViewDebtor()
        {
            ViewDebtorWindow vdw = new ViewDebtorWindow(CurrentDebtor);
            if (vdw.ShowDialog() == true)
            {
            }
        }
    }
}