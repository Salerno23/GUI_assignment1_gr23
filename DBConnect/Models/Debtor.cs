using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace DataBusinessLayer
{
    public class Debtor : BindableBase
    {
        private string _name;
        private int _totalDebt;

        public Debtor(string name, int value)
        {
            _name = name;
            _totalDebt = value;
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }


        public int TotalDebt
        {
            get => _totalDebt;
            set => SetProperty(ref _totalDebt, value);
        }
    }
}
