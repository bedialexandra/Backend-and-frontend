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
using System.Collections.ObjectModel;

namespace WPF_hattertarolok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<Hattertarolo> hattertarolok = new ObservableCollection<Hattertarolo>();

        Fajlstruktura ujfajl = new Fajlstruktura();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = hattertarolok;
            gbox_ujfajl.DataContext = ujfajl;

            hattertarolok.Add(new Hattertarolo(1000));
            hattertarolok.Add(new Hattertarolo(2000));

            hattertarolok[0].Hozzaad(new Fajlstruktura() { fajlnev="Valami.txt", meret=200});
            hattertarolok[0].Hozzaad(new Fajlstruktura() { fajlnev="Szöveg.txt", meret=100, csakolvashato=true});
            hattertarolok[1].Hozzaad(new Fajlstruktura() { fajlnev="kép.jpg", meret=500});

        }

        private void btn_ujHatterTarolo_Click(object sender, RoutedEventArgs e)
        {
            hattertarolok.Add(new Hattertarolo(int.Parse(tbox_ujHatterTaroloMeret.Text)));
            tbox_ujHatterTaroloMeret.Text = "";
            tbox_ujHatterTaroloMeret.Focus();
        }

        private void btn_ujfajl_Click(object sender, RoutedEventArgs e)
        {
            if (lbox_hatterTarolo.SelectedIndex==-1)
            {
                return;
            }

            hattertarolok[lbox_hatterTarolo.SelectedIndex].Hozzaad(ujfajl);
            ujfajl.fajlnev = "";
            ujfajl.meret = null;
            ujfajl.csakolvashato = false;
            ujfajl.rejtettfajl = false;
            ujfajl.rendszer = false;
        }

        private void BTN_torol_Click(object sender, RoutedEventArgs e)
        {
            hattertarolok[lbox_hatterTarolo.SelectedIndex].torol(lbox_fajlok.SelectedIndex);
        }

        private void btn_formazas_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Biztos akarod-e formázni?","Formázás",MessageBoxButton.YesNo)==MessageBoxResult.Yes)
            {
                hattertarolok[lbox_hatterTarolo.SelectedIndex].formaz();
            }
            
        }

        private void btn_keres_Click(object sender, RoutedEventArgs e)
        {
            tbl_fajlTalalat.Text = hattertarolok[lbox_hatterTarolo.SelectedIndex].keres(tbox_fajlnevKereses.Text);
        }

        private void btn_ujfloppy_Click(object sender, RoutedEventArgs e)
        {
            hattertarolok.Add(new Floppy());
        }
    }
}
