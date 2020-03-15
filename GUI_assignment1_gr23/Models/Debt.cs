using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace GUI_assignment1_gr23
{
    public class Debt : BindableBase
    {

        private string _date;
        private int _value;

        //Default constructor
        public Debt()
        {
            _date = DateTime.Now.ToString();
            _value = 0;
        }

        public Debt(int value)
        {
            _date = DateTime.Now.ToShortDateString();
            _value = value;
        }

        public string Date
        {
            get => _date;
        }

        public int Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
    }
}
