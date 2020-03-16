using Prism.Mvvm;

namespace DataBusinessLayer
{
    public class Debtor : BindableBase
    {
        private string _name;
        private int _totalDebt;
        private int _id;

        public Debtor(string name, int value, int id)
        {
            _name = name;
            _totalDebt = value;
            _id = id;
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


        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }
    }
}
