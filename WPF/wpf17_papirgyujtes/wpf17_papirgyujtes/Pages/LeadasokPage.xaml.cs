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

using wpf17_papirgyujtes.Models;
using System.Collections.ObjectModel;
using System.Linq;
using System.ComponentModel;

namespace wpf17_papirgyujtes.Pages
{
    /// <summary>
    /// Interaction logic for LeadasokPage.xaml
    /// </summary>
    public partial class LeadasokPage : Page
    {
        ObservableCollection<TanuloModel> tanulok = new ObservableCollection<TanuloModel>();
        ObservableCollection<LeadasokModel> leadasok = new ObservableCollection<LeadasokModel>();

        LeadasokModel ujLeadas = new LeadasokModel();

        ICollectionView filteredTanulok;

        public LeadasokPage()
        {
            InitializeComponent();
            tanulok = TanuloModel.select();

            filteredTanulok = CollectionViewSource.GetDefaultView(tanulok);
            SP_osztalyTanulo.DataContext = filteredTanulok;

            CBO_osztaly.ItemsSource = tanulok.Select(x => x.osztaly).Distinct();
            CBO_osztaly.SelectedIndex = 0;

            ujLeadas.idopont = DateTime.Now;
            SP_ujLeadas.DataContext = ujLeadas;

        }

        private void CBO_osztaly_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filteredTanulok.Filter = (object obj) =>
            {
                TanuloModel tanulo = obj as TanuloModel;
                if (tanulo != null)
                {
                    return tanulo.osztaly == CBO_osztaly.SelectedItem.ToString();
                }
                return false;
            };
            CBO_tanulo.SelectedIndex = 0;
        }

        private void CBO_tanulo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CBO_tanulo.SelectedItem != null)
            {
                tanuloListaFrissites();
            }
            
        }

        private void BTN_ujMennyiseg_Click(object sender, RoutedEventArgs e)
        {
            ujLeadas.tanulo = (int)CBO_tanulo.SelectedValue;
            LeadasokModel.insert(ujLeadas);
            tanuloListaFrissites();
        }

        private void tanuloListaFrissites()
        {
            leadasok = LeadasokModel.select((int)CBO_tanulo.SelectedValue);
            DG_leadasok.ItemsSource = leadasok;
            TBL_osszesMennyiseg.Text = string.Format("Összes mennyiség: {0} dkg.", leadasok.Sum(x => x.mennyiseg));
        }
    }
}
