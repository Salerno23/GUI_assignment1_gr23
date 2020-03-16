using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataBusinessLayer;
using GUI_assignment1_gr23.ViewModels;

namespace GUI_assignment1_gr23.Views
{
    /// <summary>
    /// Interaction logic for ViewDebtorWindow.xaml
    /// </summary>
    public partial class ViewDebtorWindow : Window
    {
        /*
         * Not pretty code. Don't look. Breaks MVVM.
         */
        public ViewDebtorWindow(Debtor debtor)
        {
            var vm = new ViewDebtorWindowViewModel(debtor);
            DataContext = vm;
            InitializeComponent();
        }
    }
}
