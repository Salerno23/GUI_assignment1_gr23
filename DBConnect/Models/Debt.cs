using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace DataBusinessLayer
{
    public class Debt : BindableBase
    {
        private DateTime _date;
        private int _value;

        public Debt(int value, DateTime date)
        {
            _date = date;
            _value = value;
        }

        public string Date
        {
            get => _date.ToString("s");
        }

        public int DebtValue
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
    }
}
