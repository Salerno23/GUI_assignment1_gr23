using DataBusinessLayer;
using GUI_assignment1_gr23.ViewModels;
using System.Windows;

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
