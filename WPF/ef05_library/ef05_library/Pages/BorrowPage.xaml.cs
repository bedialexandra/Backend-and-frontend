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

using ef05_library.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ef05_library.Pages
{
    /// <summary>
    /// Interaction logic for BorrowPage.xaml
    /// </summary>
    public partial class BorrowPage : Page
    {
        _14a_libraryContext context = new _14a_libraryContext();

        public BorrowPage()
        {
            InitializeComponent();

            context.Students.Load();
            context.Books.Load();
            context.Borrows.Load();
            context.Authors.Load();

            CBO_osztaly.ItemsSource = (from o in context.Students
                                       select o.Class).ToList().Distinct().OrderBy(x => x);
            CBO_osztaly.SelectedIndex = 0;

            CBO_szerzok.ItemsSource = context.Authors.Local.ToObservableCollection();
            CBO_szerzok.SelectedIndex = 0;

            SP_kolcsonzes.Visibility = Visibility.Hidden;
        }

        private void CBO_osztaly_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tanuloSzures();
        }

       

        private void TB_kereses_TextChanged(object sender, TextChangedEventArgs e)
        {
            tanuloSzures();
        }

        private void tanuloSzures()
        {
            var tanuloLista = (from t in context.Students
                               where t.Class == CBO_osztaly.SelectedItem.ToString() && (t.Name.Contains(TB_kereses.Text) || t.Surname.Contains(TB_kereses.Text))
                               orderby t.Name, t.Surname
                               select t
                               ).ToList();
            LB_tanulok.ItemsSource = tanuloLista;
            SP_kolcsonzes.Visibility = Visibility.Hidden;
        }

        private void LB_tanulok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (LB_tanulok.SelectedItem != null)
            {
                konyvListaFrissites();
                SP_kolcsonzes.Visibility = Visibility.Visible;
            } else
            {
                LB_kolcsonzottKonyvek.ItemsSource = null;
            }
        }

        

        private void BTN_kolcsonoz_Click(object sender, RoutedEventArgs e)
        {

            if (ujKonyvUrlapEllenorzes())
            {
                return;
            }

            Borrow kolcsonzes = new Borrow()
            {
                BookId = ((Book)LB_konyvek.SelectedItem).BookId,
                StudentId = ((Student)LB_tanulok.SelectedItem).StudentId,
                BroughtDate = DP_kiadva.SelectedDate,
                TakenDate = DateTime.Now
            };
            context.Add<Borrow>(kolcsonzes);
            context.SaveChanges();
            konyvListaFrissites();
        }

       

        private void CBO_szerzok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var konyvLista = (from k in context.Books
                              where k.AuthorId == ((Author)CBO_szerzok.SelectedItem).AuthorId
                              select k
                              ).ToList();
            LB_konyvek.ItemsSource = konyvLista;
        }
        private void BTN_torles_Click(object sender, RoutedEventArgs e)
        {
            if (LB_kolcsonzottKonyvek.SelectedItem != null)
            {
                dynamic k = LB_kolcsonzottKonyvek.Items.GetItemAt(LB_kolcsonzottKonyvek.SelectedIndex);
                int bId = k.BorrowId;
                var kivalsztottKonyv = (from b in context.Borrows
                                        where b.BorrowId == bId
                                        select b
                                        ).FirstOrDefault();
                context.Remove<Borrow>(kivalsztottKonyv);
                context.SaveChanges();
                konyvListaFrissites();
            }
        }

        private void konyvListaFrissites()
        {
            var konyvLista = (from k in context.Borrows
                              where k.StudentId == ((Student)LB_tanulok.SelectedItem).StudentId
                              select new
                              {
                                  k.BorrowId,
                                  k.Book.Name,
                                  k.Book.Author.FullName,
                                  datum = string.Format("{0:yyyy.MM.dd} - {1:yyyy.MM.dd}", k.TakenDate, k.BroughtDate)
                              }
                              ).ToList();
            LB_kolcsonzottKonyvek.ItemsSource = konyvLista;
        }


        private bool ujKonyvUrlapEllenorzes()
        {
            LB_konyvek.BorderBrush = Brushes.LightGray;
            DP_kiadva.BorderBrush = Brushes.LightGray;

            if (LB_konyvek.SelectedItem == null)
            {
                LB_konyvek.BorderBrush = Brushes.Red;
                return true;
            }

            if (DP_kiadva.SelectedDate == null)
            {
                DP_kiadva.BorderBrush = Brushes.Red;
                return true;
            }

            return false;
        }

       
    }
}
