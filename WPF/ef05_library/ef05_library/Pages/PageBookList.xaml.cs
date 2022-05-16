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
    /// Interaction logic for PageBookList.xaml
    /// </summary>
    public partial class PageBookList : Page
    {
        _14a_libraryContext context = new _14a_libraryContext();

        public PageBookList()
        {
            InitializeComponent();

            context.Books.Load();
            context.Authors.Load();
            context.Types.Load();

            //CBO_szerzok.ItemsSource = context.Authors.Local.ToObservableCollection();
            var a = context.Authors.Local.OrderBy(x => x.FullName).ToList();
            a.Insert(0, new Author() { AuthorId = 0, Name = "Kérem válasszon!" });
            CBO_szerzok.ItemsSource = a;
            CBO_szerzok.SelectedIndex = 0;

            var t = context.Types.Local.OrderBy(x => x.Name).ToList();
            t.Insert(0, new ef05_library.Models.Type() { TypeId = 0, Name="Kérem válasszon!" });
            CBO_kategoriak.ItemsSource = t;
            CBO_kategoriak.SelectedIndex = 0;

            DG_konyvLista.ItemsSource = context.Books.Local.ToObservableCollection();
        }

        private void BTN_kereses_Click(object sender, RoutedEventArgs e)
        {
            var szurtlista = (from b in context.Books select b);

            if (!string.IsNullOrEmpty(TB_cim.Text))
            {
                szurtlista = (from b in szurtlista
                              where b.Name.Contains(TB_cim.Text)
                              select b);
            }

            if (CBO_szerzok.SelectedIndex != 0)
            {
                szurtlista = (from b in szurtlista
                             where b.AuthorId == ((Author)CBO_szerzok.SelectedItem).AuthorId
                             select b);
            }

            if (CBO_kategoriak.SelectedIndex != 0)
            {
                szurtlista = (from k in szurtlista
                              where k.TypeId == ((ef05_library.Models.Type)CBO_kategoriak.SelectedItem).TypeId
                              select k);
            }

            DG_konyvLista.ItemsSource = szurtlista.ToList();
        }
    }
}
