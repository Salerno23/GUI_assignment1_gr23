using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace GUI_assignment1_gr23
{
    class ViewDebtorWindowViewModel : BindableBase
    {
        public ObservableCollection<Debt> Debts { get; set; }
        string currentvalue = null;

        public ViewDebtorWindowViewModel()
        {
            Debts = new ObservableCollection<Debt>
            {
                new Debt(35) //Test
            };
        }

    public void AddValue()
        {
            int valuetemp = int.Parse(currentvalue);
            Debts.Add(new Debt(valuetemp));
            TextboxValue = string.Empty;
        }

        public void CloseWindow()
        {
            
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
