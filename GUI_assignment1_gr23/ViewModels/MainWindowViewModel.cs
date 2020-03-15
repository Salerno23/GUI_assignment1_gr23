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
using Prism.Commands;
using Prism.Mvvm;

namespace GUI_assignment1_gr23
{
    class MainWindowViewModel : BindableBase
    {
        //Make instance to access CurrentDeptor in ViewDeptorViewModel
        private static MainWindowViewModel _instance = new MainWindowViewModel();
        public static MainWindowViewModel Instance { get { return _instance; } }



        public ObservableCollection<Debtor> DebtorObsList { get; set; }

        public MainWindowViewModel()
        {
            DebtorObsList = new ObservableCollection<Debtor>
            {
                new Debtor("Test", 5),
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
            if (vdw.ShowDialog() == true)
            {
                //Do something with data
            }
        }
    }
}