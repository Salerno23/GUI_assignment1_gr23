using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GUI_assignment1_gr23.Annotations;
using Prism.Mvvm;

namespace GUI_assignment1_gr23
{
    public class Debtor : BindableBase
    {
        private string _name;
        private int _deptorValue;

        //Default constructor
        public Debtor()
        {
            _name = "";
            _deptorValue = 0;
        }

        public Debtor(string name, int value)
        {
            _name = name;
            _deptorValue = value;
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public int Value
        {
            get => _deptorValue;
            set => SetProperty(ref _deptorValue, value);
        }
    }
}
