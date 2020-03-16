using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DataBusinessLayer;
using DBConnect;

namespace GUI_assignment1_gr23
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static DebtDb debtDb = new DebtDb();

        public static DebtDb DebtDb
        {
            get { return debtDb; }
        }
    }
}
