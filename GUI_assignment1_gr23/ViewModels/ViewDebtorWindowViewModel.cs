using DataBusinessLayer;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace GUI_assignment1_gr23.ViewModels
{
    public class ViewDebtorWindowViewModel : BindableBase
    {
        private readonly Debtor _currentDebtor;

        private ObservableCollection<Debt> _debtList;

        public ObservableCollection<Debt> DebtList
        {
            get => _debtList;
            set => SetProperty(ref _debtList, value);
        }

        public ViewDebtorWindowViewModel(Debtor debtor)
        {
            _currentDebtor = debtor;
            _debtList = (ObservableCollection<Debt>) App.DebtDb.GetDebtsFor(_currentDebtor.Id);
        }
        
        private string _currentValue = "";

        public string TextboxValue
        {
            get => _currentValue;
            set =>  SetProperty(ref _currentValue, value);
        }

        private ICommand _addValueCommand;
        public ICommand AddValueCommand => _addValueCommand ?? 
                                           (_addValueCommand = new DelegateCommand(
                                                   AddValue, 
                                                   () => TextboxValue != "")
                                               .ObservesProperty(() => TextboxValue));

        private void AddValue()
        {
            int valueTemp = int.Parse(_currentValue);
            Debt newDebt = new Debt(valueTemp, DateTime.Now);
            _currentDebtor.TotalDebt += valueTemp;

            App.DebtDb.AddNewDebtFor(_currentDebtor, newDebt);

            DebtList = (ObservableCollection<Debt>) App.DebtDb.GetDebtsFor(_currentDebtor.Id);

            TextboxValue = string.Empty;
        }

        private ICommand _closeWindowCommand;

        public ICommand CloseWindowCommand
        {
            get => _closeWindowCommand ?? (_closeWindowCommand = new DelegateCommand<Window>(CloseWindow));
        }

        private void CloseWindow(Window window)
        {
            window.Close();
        }
    }
}
