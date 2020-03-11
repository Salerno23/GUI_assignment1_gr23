using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_assignment1_gr23
{
    class Deptor
    {
        string name;
        int deptorValue;

        //Default constructor
        public Deptor()
        {

        }

        public Deptor(string _name, int _value)
        {
            name = _name;
            deptorValue = _value;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Value
        {
            get
            {
                return deptorValue;
            }
            set
            {
                deptorValue = value;
            }
        }

    }
}
