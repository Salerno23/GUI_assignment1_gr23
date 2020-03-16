using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using DataBusinessLayer;
using GUI_assignment1_gr23.Annotations;
using Prism.Commands;
using Prism.Mvvm;

namespace GUI_assignment1_gr23
{
    class AddDebtorWindowViewModel : BindableBase
    {
        
        public AddDebtorWindowViewModel() { }

        private string _firstName;

        public string FirstName
        {
            get => _firstName;
            set => SetProperty(ref _firstName, value);
        }

        private int _initialValue;

        public int InitialValue
        {
            get => _initialValue;
            set => SetProperty(ref _initialValue, value);
        }

        private ICommand _saveDebtorCommand;

        public ICommand SaveDebtorCommand => _saveDebtorCommand ??
                                             (_saveDebtorCommand = new DelegateCommand<Window>(AddDebtor));

        private void AddDebtor(Window window)
        {
            int debtorsAmount = App.DebtDb.GetDebtors().Count;

            Debtor debtor = new Debtor(_firstName, _initialValue, debtorsAmount + 1);
            Debt debt = new Debt(_initialValue, DateTime.Now);

            App.DebtDb.AddNewDebtor(debtor, debt);
            window.Close();
        }
    }
}
