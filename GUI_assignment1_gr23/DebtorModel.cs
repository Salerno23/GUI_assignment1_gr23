using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_assignment1_gr23
{
    public class DebtorModel
    {
        public DebtorModel()
        {
            DebtorObsList = new ObservableCollection<Deptor>();
        }

        public ObservableCollection<Deptor> DebtorObsList { get; set; }
    }
}
