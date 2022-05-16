using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Bédi_Alexandra_Munkavállalók
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Munkavállaló> munkavallalok = new ObservableCollection<Munkavállaló>();
        

        public MainWindow()
        {
            InitializeComponent();
            lbox_munkavallalok.ItemsSource = munkavallalok;
            this.DataContext = munkavallalok;
            lbox_munkavallalok.ItemsSource = munkavallalok;
            munkavallalok.Add(new Munkavállaló() { nev="Józsi", evesSzabadsag=25, fizetesiKategoria=2, osszkivettSzabadsag = 0 });
            munkavallalok.Add(new Munkavállaló() { nev="Péter", evesSzabadsag=30, fizetesiKategoria=3, osszkivettSzabadsag=0});
            munkavallalok.Add(new Munkavállaló() { nev="Elemér", evesSzabadsag=29, fizetesiKategoria=5, osszkivettSzabadsag=0});

            cbox_fizetesiKategoria.ItemsSource = new int[] { 1,2,3,4,5};
            cbox_fizetesiKategoria.SelectedIndex = 0;
            lbox_munkavallalok.SelectedIndex = 0;
            
        }

        private void btn_Mentes_Click(object sender, RoutedEventArgs e)
        {
            int szabadsag;
            if (tbox_nev.Text=="")
            {
                tblock_nevError.Text = string.Format("Töltsd ki a név mezőt!");
            }
            if (tbox_evesSzabadsag.Text=="")
            {
                tblock_szabadsagError.Text = string.Format("Töltsd ki az éves szabadság mezőt!");
            }
            else if (!int.TryParse(tbox_evesSzabadsag.Text, out szabadsag))
            {
                tblock_szabadsagError.Text = string.Format("Az érték csak szám lehet!");
            }
            else if (!(tbox_nev.Text=="" && tbox_evesSzabadsag.Text==""))
            {
                munkavallalok.Add(new Munkavállaló() { nev=tbox_nev.Text, fizetesiKategoria=cbox_fizetesiKategoria.SelectedIndex+1, evesSzabadsag=int.Parse(tbox_evesSzabadsag.Text), osszkivettSzabadsag=0});
                
                tbox_nev.Text = "";
                cbox_fizetesiKategoria.SelectedIndex = 0;
                tbox_evesSzabadsag.Text = "";
                
            }
            
        }

        private void btn_szabadsagIgeny_Click(object sender, RoutedEventArgs e)
        {
            
            

            for (int i = 0; i < munkavallalok.Count; i++)
            {
                
                if (lbox_munkavallalok.SelectedIndex == i)
                {
                    if (int.Parse(tbox_szabadsagIgeny.Text) < 10 && (munkavallalok[i].maradekSzabadsag > int.Parse(tbox_szabadsagIgeny.Text)))
                    {
                        munkavallalok[i].osszkivettSzabadsag += int.Parse(tbox_szabadsagIgeny.Text);
                        //munkavallalok[i].Hozzaad( int.Parse(tbox_szabadsagIgeny.Text));
                        tbox_szabadsagIgeny.Text = "";
                    }
                }

            }
                       
        }
    }
}
