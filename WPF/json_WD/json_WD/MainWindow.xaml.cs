using System;
using System.Collections.Generic;
using System.IO;
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

using json_WD.Models;
using Newtonsoft.Json;

namespace json_WD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index = 0;
        public WDRootModel WDRootModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            string json = File.ReadAllText("the_walking_dead.json");

            WDRootModel = JsonConvert.DeserializeObject<WDRootModel>(json);

            // index = WDRootModel.episodes.Count - 1;
            SP_film.DataContext = WDRootModel.episodes[index];
        }

        private void BTN_prev_Click(object sender, RoutedEventArgs e)
        {
            index--;
            if (index == -1) index = 0;
            SP_film.DataContext = WDRootModel.episodes[index];
        }

        private void BTN_next_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index == WDRootModel.episodes.Count) index = WDRootModel.episodes.Count - 1;
            SP_film.DataContext = WDRootModel.episodes[index];
        }
    }
}
