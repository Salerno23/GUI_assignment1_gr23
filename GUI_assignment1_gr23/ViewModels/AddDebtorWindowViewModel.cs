using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataBusinessLayer;
using Prism.Commands;
using Prism.Mvvm;

namespace GUI_assignment1_gr23
{
    class AddDebtorWindowViewModel : BindableBase
    {
        

        public AddDebtorWindowViewModel()
        {
            
        }

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
                                             (_saveDebtorCommand = new DelegateCommand(AddDebtor));

        private void AddDebtor()
        {

        }
    }
}
