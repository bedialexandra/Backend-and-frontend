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

using System.Collections.ObjectModel;
using wpf17_papirgyujtes.Models;
using System.Linq;

namespace wpf17_papirgyujtes.Pages
{
    /// <summary>
    /// Interaction logic for StatisztikaPage.xaml
    /// </summary>
    public partial class StatisztikaPage : Page
    {
        ObservableCollection<TanuloModel> tanulok = new ObservableCollection<TanuloModel>();

        ObservableCollection<StatisztikaModel> osztalyTanuloOsszesen = new ObservableCollection<StatisztikaModel>();

        ObservableCollection<StatisztikaModel> legkevesebbMennyisegOsztaly = new ObservableCollection<StatisztikaModel>();
        ObservableCollection<StatisztikaModel> legtobbMennyisegOsztaly = new ObservableCollection<StatisztikaModel>();

        ObservableCollection<StatisztikaModel> mennyisegOsztaly = new ObservableCollection<StatisztikaModel>();

        public StatisztikaPage()
        {
            InitializeComponent();
            tanulok = TanuloModel.select();
            CBO_osztaly.ItemsSource = tanulok.Select(x => x.osztaly).Distinct();
            CBO_osztaly.SelectedIndex = 0;

            mennyisegOsztaly = StatisztikaModel.selectMennyisegOsztaly();
            DG_osztalyok.ItemsSource = mennyisegOsztaly;
        }

        private void CBO_osztaly_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            osztalyTanuloOsszesen = StatisztikaModel.selectOsztalyTanuloOsszesen(CBO_osztaly.SelectedItem.ToString());
            DG_osszesites.ItemsSource = osztalyTanuloOsszesen;

            legkevesebbMennyisegOsztaly = StatisztikaModel.selectLegkevesebbLegtobbMennyiseg(CBO_osztaly.SelectedItem.ToString(), "ASC");
            DG_legkevesebb.ItemsSource = legkevesebbMennyisegOsztaly;

            legtobbMennyisegOsztaly = StatisztikaModel.selectLegkevesebbLegtobbMennyiseg(CBO_osztaly.SelectedItem.ToString(), "DESC");
            DG_legtobb.ItemsSource = legtobbMennyisegOsztaly;
        }
    }
}
