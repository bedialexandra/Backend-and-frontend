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

namespace Emberek_kutyak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Ember> emberek = new ObservableCollection<Ember>();
        Kutya ujkutya = new Kutya();


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = emberek;
            sp_kutya.DataContext = ujkutya;
            

            emberek.Add(new Ember() { nev="Józsi", eletkor=30});
            emberek.Add(new Ember() { nev = "Béla", eletkor = 40, nagyfulu=true });
            emberek[0].Hozzaad(new Kutya() { kutyaNev="Bodri", fajta="Németjuhász"});
            emberek[1].Hozzaad(new Kutya() { kutyaNev="Dominó", fajta="Bernáthegyi"});
        }

        private void btn_mentesEmber_Click(object sender, RoutedEventArgs e)
        {
            emberek.Add(new Ember() { nev = tbox_nev.Text, eletkor = int.Parse(tbox_eletkor.Text) });
            tbox_nev.Text = "";
            tbox_eletkor.Text = "";
            
        }

        private void btn_mentesKutya_Click(object sender, RoutedEventArgs e)
        {
            if (lbox_ember.SelectedIndex == -1)
            {
                return;
            }

            emberek[lbox_ember.SelectedIndex].Hozzaad(ujkutya);
            tbox_kutyanev.Text = "";
            tbox_fajta.Text = "";
            ujkutya.huseges = false;
        }
    }
}
