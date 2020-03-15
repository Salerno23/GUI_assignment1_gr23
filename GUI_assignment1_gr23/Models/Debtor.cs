using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private int _debtorValue;
        private int _totalDebt;

        public ObservableCollection<Debt> Debts { get; set; }

        //Default constructor
        //public Debtor()
        //{
        //    _name = "";
        //    _debtorValue = 0;
        //}

        public Debtor(string name, int value)
        {
            _name = name;
            _debtorValue = value;
            _totalDebt = value;

            Debts = new ObservableCollection<Debt>
            {
                new Debt(value)
            };
        }

        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        public int Value
        {
            get => _debtorValue;
            set => SetProperty(ref _debtorValue, value);
        }

        public int TotalDept
        {
            get => _totalDebt;
            set => SetProperty(ref _totalDebt, value);
        }
    }
}
