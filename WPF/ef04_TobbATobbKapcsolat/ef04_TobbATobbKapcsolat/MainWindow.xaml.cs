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

namespace ef04_TobbATobbKapcsolat
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

            //context.Add<Tanulo>(new Tanulo() {tanuloNev ="Józsi", szuletesiDatum=DateTime.Parse("2000.01.01") });
            //context.Add<Tanulo>(new Tanulo() {tanuloNev ="Béla", szuletesiDatum=DateTime.Parse("1980.10.01") });
            //context.Add<Tanulo>(new Tanulo() {tanuloNev ="Kata", szuletesiDatum=DateTime.Parse("2002.06.05") });
            //context.Add<Tanulo>(new Tanulo() {tanuloNev ="Péter", szuletesiDatum=DateTime.Parse("2003.12.12") });

            //context.Add<Teszt>(new Teszt() {tesztMegnevezes="Programozás alapok" });
            //context.Add<Teszt>(new Teszt() {tesztMegnevezes="Adatbázis kezelés" });
            //context.Add<Teszt>(new Teszt() {tesztMegnevezes="EF haladó" });

            //context.SaveChanges();

            context.Teszt.Load();
            context.Tanulok.Load();
            context.tesztEredmenyek.Load();

            DG_eredmenyek.ItemsSource = context.tesztEredmenyek.Local.ToObservableCollection();

            CBO_tanulok.ItemsSource = context.Tanulok.Local.ToObservableCollection();
            CBO_teszt.ItemsSource = context.Teszt.Local.ToObservableCollection();

            CBO_teszt2.ItemsSource = context.Teszt.Local.ToObservableCollection();
            CBO_tanulo2.ItemsSource = context.Tanulok.Local.ToObservableCollection();
        }

        private void BTN_mentes_Click(object sender, RoutedEventArgs e)
        {
            var tanulo = (Tanulo)CBO_tanulok.SelectedItem;
            var teszt = (Teszt)CBO_teszt.SelectedItem;
            var idopont = DP_datum.SelectedDate;
            var eredmeny = int.Parse(TB_eredmeny.Text);

            context.tesztEredmenyek.Add(new TesztEredmenyek() {
                Tanulo = tanulo,
                Teszt = teszt,
                datum = (DateTime)idopont,
                eredmeny = eredmeny
            });
            context.SaveChanges();
        }

        private void CBO_teszt2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lista = (
                        from t in context.Tanulok
                        from te in t.Teszteredmenyek
                        where te.Teszt.tesztId == ((Teszt)CBO_teszt2.SelectedItem).tesztId 
                        select new { t.tanuloNev, te.Teszt.tesztMegnevezes, te.datum, te.eredmeny }
                        ).ToList();
            DG_lekerdezesTeszt.ItemsSource = lista;
        }

        private void CBO_tanulo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lista = (
                        from t in context.Teszt
                        from te in t.Teszteredmenyek
                        where te.Tanulo.tanuloId == ((Tanulo)CBO_tanulo2.SelectedItem).tanuloId
                        select new { t.tesztMegnevezes, te.Tanulo.tanuloNev }
                        ).ToList();

            DG_lekérdezesTanulok.ItemsSource = lista;
        }
    }
}
