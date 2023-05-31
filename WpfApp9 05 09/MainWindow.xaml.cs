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
using System.Windows.Shapes;

namespace WpfApp9_05_09
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            load.Minimum = 0;
            load.Maximum = 100;


        }

        private async void Window_load_Activated(object sender, EventArgs e)
        {
            await Task.Delay(600);
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 10;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 11;
            label.Content = "Betöltés...";
            await Task.Delay(200);
            load.Value = 12;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 13;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            label.Content = "Betöltés...";
            await Task.Delay(100);
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 14;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            label.Content = "Betöltés...";
            await Task.Delay(100);
            load.Value = 15;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            label.Content = "Betöltés..";
            load.Value = 20;
            await Task.Delay(100);
            label.Content = "Betöltés...";
            await Task.Delay(100);
            load.Value = 22;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 27;
            label.Content = "Betöltés...";
            await Task.Delay(510);
            label.Content = "Betöltés.";
            load.Value = 30;
            await Task.Delay(100);
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 35;
            label.Content = "Betöltés...";
            await Task.Delay(100);
            load.Value = 43;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 44;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 45;
            label.Content = "Betöltés...";
            await Task.Delay(510);
            load.Value = 46;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            label.Content = "Betöltés..";
            await Task.Delay(100);
            label.Content = "Betöltés...";
            await Task.Delay(100);
            load.Value = 47;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 48;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 49;
            label.Content = "Betöltés...";
            await Task.Delay(100);
            load.Value = 50;
            await Task.Delay(200);
            load.Value = 53;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 56;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 59;
            label.Content = "Betöltés...";
            await Task.Delay(100);
            load.Value = 62;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 65;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 68;
            label.Content = "Betöltés...";
            await Task.Delay(200);
            load.Value = 71;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 72;
            label.Content = "Betöltés...";
            await Task.Delay(100);
            load.Value = 73;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 74;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            label.Content = "Betöltés...";
            load.Value = 75;
            await Task.Delay(250);
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 78;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 81;
            label.Content = "Betöltés...";
            await Task.Delay(100);
            load.Value = 84;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 87;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 88;
            label.Content = "Betöltés...";
            await Task.Delay(100);
            load.Value = 90;
            await Task.Delay(200);
            load.Value = 91;
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 92;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 93;
            label.Content = "Betöltés...";
            await Task.Delay(100);
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 94;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            label.Content = "Betöltés...";
            load.Value = 95;
            await Task.Delay(500);
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 96;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            load.Value = 97;
            label.Content = "Betöltés...";
            await Task.Delay(1500);
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 98;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            label.Content = "Betöltés.";
            await Task.Delay(100);
            load.Value = 99;
            label.Content = "Betöltés..";
            await Task.Delay(100);
            label.Content = "Betöltés...";
            load.Value = 100;
            await Task.Delay(1000);
            label.Content = "Betöltés.";
            await Task.Delay(100);
            label.Content = "Betöltés..";
            await Task.Delay(100);
            label.Content = "Betöltés...";
            /*await Task.Delay(100);
            label.Content = "Betöltés.";
            await Task.Delay(100);
            label.Content = "Betöltés..";
            await Task.Delay(100);
            label.Content = "Betöltés...";*/
            Window2 mainablak = new Window2();
            mainablak.Show();
            Close();
        }


    }
}
