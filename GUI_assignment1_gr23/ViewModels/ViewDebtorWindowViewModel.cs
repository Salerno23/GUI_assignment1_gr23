using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataBusinessLayer;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using UsingEventAggregator.Core;

namespace GUI_assignment1_gr23
{
    class ViewDebtorWindowViewModel : BindableBase
    {
        string currentvalue = null;
        Debtor currentdebtor = null;

        public ViewDebtorWindowViewModel(IEventAggregator ea)
        {
            ea.GetEvent<CurrentDebtorSentEvent>().Subscribe(Currentdebtor);
        }

        private void Currentdebtor(Debtor parameter)
        {
            currentdebtor = parameter;
        }

        public void AddValue()
        { 
            int valuetemp = int.Parse(currentvalue);
            DebtList.Add(new Debt(valuetemp, DateTime.Now.Date));
            currentdebtor.TotalDebt += valuetemp;
            TextboxValue = string.Empty;
        }

        public void CloseWindow()
        {
            
        }

        public ObservableCollection<Debt> DebtList
        {
            get
            {
                return (ObservableCollection<Debt>)App.DebtDb.GetDebtsFor(currentdebtor.Id);
            }
        }

        public string TextboxValue
        {
            get
            {
                return currentvalue;
            }
            set
            {
                SetProperty(ref currentvalue, value);
            }
        }


        ICommand addValue;

        public ICommand AddValueCommand
        {
            get
            {
                return addValue ?? (addValue = new DelegateCommand(AddValue, AddValueCanExecute).ObservesProperty(() => TextboxValue));
            }
        }

        private bool AddValueCanExecute()
        {
            if(TextboxValue != "")
            {
                return true;
            }
            return false;
        }

        ICommand closeWindow;

        public ICommand CloseWindowCommand
        {
            get
            {
                return closeWindow ?? (closeWindow = new DelegateCommand(CloseWindow));
            }
        }

    }
}
