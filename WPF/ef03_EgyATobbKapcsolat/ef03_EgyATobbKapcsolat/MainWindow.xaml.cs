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

using Microsoft.EntityFrameworkCore;

namespace ef03_EgyATobbKapcsolat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IskolaContext context = new IskolaContext();
        public MainWindow()
        {
            InitializeComponent();

            //Osztaly osztaly = new Osztaly() { osztalyNev = "14A", osztalyFonok = "Sándor László" };
            //context.Add<Osztaly>(osztaly);

            //osztaly = new Osztaly() { osztalyNev = "14F", osztalyFonok = "Horváth Norbert" };
            //context.Add<Osztaly>(osztaly);

            //context.SaveChanges();

            //Tanulo tanulo = new Tanulo() { tanuloNev = "Székely Áron", szuletesiDatum = DateTime.Parse("2001.01.03"), osztalyId=1 };
            //context.Add<Tanulo>(tanulo);

            //tanulo = new Tanulo() { tanuloNev = "Butyka Dávid", szuletesiDatum = DateTime.Parse("2001.08.10"), osztalyId=1 };
            //context.Add<Tanulo>(tanulo);

            //tanulo = new Tanulo() { tanuloNev = "Kakics Tamás", szuletesiDatum = DateTime.Parse("2001.08.10"), osztalyId=1 };
            //context.Add<Tanulo>(tanulo);


            //tanulo = new Tanulo() { tanuloNev = "Meronka Patrik", szuletesiDatum = DateTime.Parse("2001.01.10"), osztalyId=2 };
            //context.Add<Tanulo>(tanulo);

            //tanulo = new Tanulo() { tanuloNev = "Fazekas Balázs", szuletesiDatum = DateTime.Parse("2001.12.10"), osztalyId = 2 };
            //context.Add<Tanulo>(tanulo);


            //context.SaveChanges();

            context.Tanulok.Load();
            context.Osztalyok.Load();

            DG_tanulok.ItemsSource = context.Tanulok.Local.ToObservableCollection();

            DG_osztaly.ItemsSource = context.Osztalyok.Local.ToObservableCollection();

            //var osszestanulo = (from t in context.Tanulok
            //                   select t).ToList();

            //var osszestanulo = (from t in context.Tanulok
            //                    select new { t.tanuloNev, t.szuletesiDatum, t.Osztaly.osztalyNev }
            //                    ).ToList();

            var osszestanulo = (from t in context.Tanulok
                                where t.Osztaly.osztalyNev == "14a"
                                select new { t.tanuloNev, t.szuletesiDatum, t.Osztaly.osztalyNev }
                               ).ToList();

            DG_lekredezes.ItemsSource = osszestanulo;


            var o = context.Osztalyok.Local.OrderBy(o => o.osztalyNev).ToList();
            o.Insert(0, new Osztaly() { osztalyId = 0, osztalyNev = "Kérem válasszon!" });
            CBO_osztalyok.ItemsSource = o;
            CBO_osztalyok.DisplayMemberPath = "osztalyNev";
            CBO_osztalyok.SelectedIndex = 0;
        }

        private void CBO_osztalyok_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var osszestanulo = (from t in context.Tanulok
                                where t.Osztaly.osztalyNev == ((Osztaly)CBO_osztalyok.SelectedItem).osztalyNev
                                select new { t.tanuloNev, t.szuletesiDatum, t.Osztaly.osztalyNev }
                              ).ToList();

            DG_lekredezes.ItemsSource = osszestanulo;
        }
    }
}
