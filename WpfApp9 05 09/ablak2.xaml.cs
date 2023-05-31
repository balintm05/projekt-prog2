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
    /// Interaction logic for ablak2.xaml
    /// </summary>
    public partial class ablak2 : Window
    {
        public ablak2()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 mainablak = new Window2();
            mainablak.Show();
            Close();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sajnos az összes jegy elkelt");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Üzemen kívül");
        }
    }
}
