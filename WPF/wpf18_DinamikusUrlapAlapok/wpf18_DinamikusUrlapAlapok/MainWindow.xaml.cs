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

namespace wpf18_DinamikusUrlapAlapok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid sajatGrid = new Grid();

        public MainWindow()
        {
            InitializeComponent();
            ablak.Width = 400;
            ablak.Height = 400;
            ablak.Title = "Dinamikus űrlap";

            sajatGrid.ShowGridLines = true;

            ColumnDefinition oszlop1 = new ColumnDefinition();
            ColumnDefinition oszlop2 = new ColumnDefinition();
            ColumnDefinition oszlop3 = new ColumnDefinition();

            sajatGrid.ColumnDefinitions.Add(oszlop1);
            sajatGrid.ColumnDefinitions.Add(oszlop2);
            sajatGrid.ColumnDefinitions.Add(oszlop3);

            oszlop1.Width = new GridLength(100);
            oszlop2.Width = new GridLength(2, GridUnitType.Star);

            RowDefinition sor1 = new RowDefinition();
            RowDefinition sor2 = new RowDefinition();
            RowDefinition sor3 = new RowDefinition();

            sajatGrid.RowDefinitions.Add(sor1);
            sajatGrid.RowDefinitions.Add(sor2);
            sajatGrid.RowDefinitions.Add(sor3);

            sor1.Height = new GridLength(50);

            // label
            Label cimke1 = new Label();
            cimke1.Content = "CIMKE";
            cimke1.FontSize = 20;
            cimke1.Margin = new Thickness(5);
            cimke1.Foreground = Brushes.Blue;

            Grid.SetRow(cimke1, 0);
            Grid.SetColumn(cimke1, 0);

            sajatGrid.Children.Add(cimke1);


            Label cimke2 = new Label();
            cimke2.Content = "Másik cimke";
            cimke2.FontSize = 16;
            cimke2.FontWeight = FontWeights.Bold;
            cimke2.Name = "LB_cimke2";

            BrushConverter bc = new BrushConverter();
            cimke2.Foreground = (Brush)bc.ConvertFrom("#906090");

            Grid.SetRow(cimke2, 0);
            Grid.SetColumn(cimke2, 1);

            sajatGrid.Children.Add(cimke2);

            // texbox
            TextBox tb1 = new TextBox();
            tb1.Margin = new Thickness(5);
            tb1.Width = 50;
            tb1.HorizontalAlignment = HorizontalAlignment.Left;
            tb1.VerticalAlignment = VerticalAlignment.Top;
            tb1.Name = "TB_szoveg";

            Grid.SetRow(tb1, 1);
            Grid.SetColumn(tb1, 0);
            sajatGrid.Children.Add(tb1);


            // button
            Button gomb1 = new Button()
            {
                Content = "GOMB-1",
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(5),
                Padding = new Thickness(5),
                Name = "BTN_gomb1"
                
            };

            gomb1.Click += new RoutedEventHandler(Gomb_kattintas);

            Grid.SetRow(gomb1,1);
            Grid.SetColumn(gomb1, 1);

            sajatGrid.Children.Add(gomb1);

            Button gomb2 = new Button() {
                Content="Gomb 2",
                Padding = new Thickness(5),
                Name = "BTN_gomb2"
            };
            gomb2.Click += new RoutedEventHandler(Gomb_kattintas);

            Grid.SetRow(gomb2, 1);
            Grid.SetColumn(gomb2, 2);

            sajatGrid.Children.Add(gomb2);

            ablak.Content = sajatGrid;
        }

       

        private void Gomb_kattintas(object sender, RoutedEventArgs e)
        {
            var sg = sajatGrid.Children;

            //var c = (Label)sg[0];
            //c.Content = "Szöveg";

            //var tb = (from x in sg.OfType<TextBox>()
            //          where x.Name == "TB_szoveg"
            //          select x).SingleOrDefault();

            //var sz = tb.Text;

            //(from x in sg.OfType<Label>()
            // where x.Name == "LB_cimke2"
            // select x).SingleOrDefault().Content = sz;

            if (sender is Button)
            {
                string melyikGomb = (sender as Button).Name;
                //MessageBox.Show(melyikGomb);

                (from x in sg.OfType<Label>()
                 where x.Name == "LB_cimke2"
                 select x).SingleOrDefault().Content = melyikGomb;
            }

        }
    }
}
