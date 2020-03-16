using DataBusinessLayer;
using System.Windows;

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
