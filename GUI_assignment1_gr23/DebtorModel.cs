using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GUI_assignment1_gr23
{
    public class DebtorModel : INotifyPropertyChanged
    {
        private readonly Deptor _deptorHenrik = new Deptor("Henrik", 300);
        private readonly Deptor _deptorMichael = new Deptor("Michael", 600);

        public DebtorModel()
        {
            DebtorObsList = new ObservableCollection<Deptor>{_deptorHenrik, _deptorMichael};
            CurrentDeptor = DebtorObsList[_selectedIndex];
        }

        public ObservableCollection<Deptor> DebtorObsList { get; set; }

        private int _selectedIndex = 0;

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                if (_selectedIndex != value)
                {
                    _selectedIndex = value;
                    Notify();
                }
            }
        }

        private Deptor _selectedDeptor;

        public Deptor CurrentDeptor
        {
            get => _selectedDeptor;
            set
            {
                if (_selectedDeptor != value)
                {
                    _selectedDeptor = value;
                    Notify();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
