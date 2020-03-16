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
using Prism.Mvvm;

namespace GUI_assignment1_gr23
{
    class ViewDebtorWindowViewModel : BindableBase
    {
        string currentvalue = null;
        Debtor currentdebtor = null;

        public ViewDebtorWindowViewModel(Debtor currentdebtor_)
        {
            currentdebtor = currentdebtor_;
        }

        public void AddValue()
        {
            int valuetemp = int.Parse(currentvalue);

            //DebtList = (ObservableCollection<Debt>)App.DebtDb.GetDebtsFor(currentdebtor.Id);

            DebtList.Add(new Debt(valuetemp, DateTime.Now));

            //currentdebtor.Debts.Add(new Debt(valuetemp));

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
            set
            {
                //SetProperty(ref currentdebtor.Debts, value);
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


        //ICommand addValue;

        public ICommand AddValueCommand
        {
            get
            {
                return addValue ?? (addValue = new DelegateCommand(AddValue));
            }
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
