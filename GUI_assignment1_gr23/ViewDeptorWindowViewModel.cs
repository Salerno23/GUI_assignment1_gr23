using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace GUI_assignment1_gr23
{
    class ViewDeptorWindowViewModel : BindableBase
    {

        public void AddValue()
        {

        }

        public void CloseWindow()
        {
            
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
