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
using System.Windows.Navigation;
using System.Windows.Shapes;

using ef05_library.Pages;

namespace ef05_library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void M_booklist_Click(object sender, RoutedEventArgs e)
        {
            FRM_nyito.Content = new PageBookList();
        }

        private void M_book_Click(object sender, RoutedEventArgs e)
        {
            FRM_nyito.Content = new PageBook();
        }

        private void M_borrowing_Click(object sender, RoutedEventArgs e)
        {
            FRM_nyito.Content = new BorrowPage();
        }

        private void M_strudentlist_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
