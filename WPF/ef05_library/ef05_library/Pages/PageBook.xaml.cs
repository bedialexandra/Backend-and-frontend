using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.EntityFrameworkCore;
using ef05_library.Models;
using System.Linq;

namespace ef05_library.Pages
{
    /// <summary>
    /// Interaction logic for PageBook.xaml
    /// </summary>
    public partial class PageBook : Page
    {
        _14a_libraryContext context = new _14a_libraryContext();

        public PageBook()
        {
            InitializeComponent();

            context.Authors.Load();
            context.Books.Load();
            context.Types.Load();

            var a = context.Authors.Local.OrderBy(x => x.FullName).ToList();
            a.Insert(0, new Author() { AuthorId = 0, Name="Kérem válasszon!" });
            CBO_szerzok.SelectedIndex = 0;
            CBO_szerzok.ItemsSource = a;

            CBO_szerzok2.ItemsSource = context.Authors.Local.OrderBy(x => x.FullName).ToList();

            CBO_tipus.ItemsSource = context.Types.Local.OrderBy(x => x.Name).ToList();

            BTN_modosit.IsEnabled = false;
            BTN_torol.IsEnabled = false;

            formState(true);
        }

        private void CBO_szerzok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListaFrissites();
        }

        private void LB_konyvek_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SP_konyv.DataContext = LB_konyvek.SelectedItem;

            BTN_modosit.IsEnabled = true;
            BTN_torol.IsEnabled = true;
        }

        private void BTN_uj_Click(object sender, RoutedEventArgs e)
        {
            formState(false);

            BTN_uj.IsEnabled = false;
            BTN_modosit.IsEnabled = false;
            BTN_torol.IsEnabled = false;

            SP_konyv.DataContext = new Book();
        }

        private void BTN_modosit_Click(object sender, RoutedEventArgs e)
        {
            formState(false);
            BTN_uj.IsEnabled = false;
            BTN_modosit.IsEnabled = false;
            BTN_torol.IsEnabled = false;
        }

        private void BTN_torol_Click(object sender, RoutedEventArgs e)
        {
            var book = (Book)LB_konyvek.SelectedItem;
            if (MessageBox.Show("Biztosan törölhető-e? ("+book.Name+")","Törlés",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                context.Books.Remove(book);
                context.SaveChanges();
                SP_konyv.DataContext = new Book();

                ListaFrissites();
                
                BTN_uj.IsEnabled = false;
                BTN_modosit.IsEnabled = false;
                BTN_torol.IsEnabled = false;
            }
        }

        private void BTN_mentes_Click(object sender, RoutedEventArgs e)
        {
            var b = (Book)SP_konyv.DataContext;
            if (b.BookId == 0)
            {
                context.Books.Add(b);  // insert into
            } else
            {
                context.Entry(b).State = EntityState.Modified;  // update
            }
            
            context.SaveChanges();

            formState(true);

            BTN_uj.IsEnabled = true;
            BTN_modosit.IsEnabled = false;
            BTN_torol.IsEnabled = false;

            LB_konyvek.SelectedIndex = -1;
            SP_konyv.DataContext = new Book();


        }

        private void BTN_megse_Click(object sender, RoutedEventArgs e)
        {
            context.Entry(SP_konyv.DataContext).State = EntityState.Unchanged;

            ListaFrissites();
            LB_konyvek.SelectedIndex = -1;

            formState(true);

            BTN_uj.IsEnabled = true;
            BTN_modosit.IsEnabled = false;
            BTN_torol.IsEnabled = false;

            SP_konyv.DataContext = new Book();


        }

        private void ListaFrissites()
        {
            LB_konyvek.ItemsSource = (from b in context.Books
                                      where b.AuthorId == ((Author)CBO_szerzok.SelectedItem).AuthorId
                                      select b).ToList();
        }

        private void formState(bool state)
        {
            CBO_szerzok.IsEnabled = state;
            LB_konyvek.IsEnabled = state;

            SP_konyv.IsEnabled = !state;
        }
    }
}
