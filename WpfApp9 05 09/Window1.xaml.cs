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
using System.IO;

namespace WpfApp9_05_09
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        int seat1 = 0;
        int seat2 = 0;
        int seat3 = 0;
        int seat4 = 0;
        int seat5 = 0;
        int seat6 = 0;
        int seat7 = 0;
        int seat8 = 0;
        int seat9 = 0;
        public Window1()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
            comboBox.Items.Add("Csizmás kandúr");
            label1.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;
            button7.Visibility = Visibility.Hidden;
            button8.Visibility = Visibility.Hidden;
            button9.Visibility = Visibility.Hidden;
            button.Visibility = Visibility.Hidden;

            FileStream f = new FileStream("seats.txt", FileMode.OpenOrCreate);
            f.Close();
            var fileLines = File.ReadAllLines("seats.txt");
            for (int i = 0; i < fileLines.Length; i++)
            {
                if (fileLines[i]=="1")
                {
                    button1.Foreground = new SolidColorBrush(Colors.Red);
                    button1.BorderBrush = new SolidColorBrush(Colors.Red);
                    button1.IsHitTestVisible = false;
                    seat1 = 2;
                }
                if (fileLines[i] == "2")
                {
                    button2.Foreground = new SolidColorBrush(Colors.Red);
                    button2.BorderBrush = new SolidColorBrush(Colors.Red);
                    button2.IsHitTestVisible = false;
                    seat2 = 2;
                }
                if (fileLines[i] == "3")
                {
                    button3.Foreground = new SolidColorBrush(Colors.Red);
                    button3.BorderBrush = new SolidColorBrush(Colors.Red);
                    button3.IsHitTestVisible = false;
                    seat3 = 2;
                }
                if (fileLines[i] == "4")
                {
                    button4.Foreground = new SolidColorBrush(Colors.Red);
                    button4.BorderBrush = new SolidColorBrush(Colors.Red);
                    button4.IsHitTestVisible = false;
                    seat4 = 2;
                }
                if (fileLines[i] == "5")
                {
                    button5.Foreground = new SolidColorBrush(Colors.Red);
                    button5.BorderBrush = new SolidColorBrush(Colors.Red);
                    button5.IsHitTestVisible = false;
                    seat5 = 2;
                }
                if (fileLines[i] == "6")
                {
                    button6.Foreground = new SolidColorBrush(Colors.Red);
                    button6.BorderBrush = new SolidColorBrush(Colors.Red);
                    button6.IsHitTestVisible = false;
                    seat6 = 2;
                }
                if (fileLines[i] == "7")
                {
                    button7.Foreground = new SolidColorBrush(Colors.Red);
                    button7.BorderBrush = new SolidColorBrush(Colors.Red);
                    button7.IsHitTestVisible = false;
                    seat7 = 2;
                }
                if (fileLines[i] == "8")
                {
                    button8.Foreground = new SolidColorBrush(Colors.Red);
                    button8.BorderBrush = new SolidColorBrush(Colors.Red);
                    button8.IsHitTestVisible = false;
                    seat8 = 2;
                }
                if (fileLines[i] == "9")
                {
                    button9.Foreground = new SolidColorBrush(Colors.Red);
                    button9.BorderBrush = new SolidColorBrush(Colors.Red);
                    button9.IsHitTestVisible = false;
                    seat9 = 2;
                }
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            label1.Visibility = Visibility.Visible;
            button1.Visibility = Visibility.Visible;
            button2.Visibility = Visibility.Visible;
            button3.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Visible;
            button5.Visibility = Visibility.Visible;
            button6.Visibility = Visibility.Visible;
            button7.Visibility = Visibility.Visible;
            button8.Visibility = Visibility.Visible;
            button9.Visibility = Visibility.Visible;
            button.Visibility = Visibility.Visible;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (seat1==0)
            {
                button1.Foreground = new SolidColorBrush(Colors.Lime);
                button1.BorderBrush = new SolidColorBrush(Colors.Lime);
                seat1 = 1;
            }
            else if (seat1==1)
            {
                button1.Foreground = new SolidColorBrush(Colors.White);
                button1.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                seat1 = 0;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (seat2 == 0)
            {
                button2.Foreground = new SolidColorBrush(Colors.Lime);
                button2.BorderBrush = new SolidColorBrush(Colors.Lime);
                seat2 = 1;
            }
            else if (seat2 == 1)
            {
                button2.Foreground = new SolidColorBrush(Colors.White);
                button2.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                seat2 = 0;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (seat3 == 0)
            {
                button3.Foreground = new SolidColorBrush(Colors.Lime);
                button3.BorderBrush = new SolidColorBrush(Colors.Lime);
                seat3 = 1;
            }
            else if (seat3 == 1)
            {
                button3.Foreground = new SolidColorBrush(Colors.White);
                button3.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                seat3 = 0;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (seat4 == 0)
            {
                button4.Foreground = new SolidColorBrush(Colors.Lime);
                button4.BorderBrush = new SolidColorBrush(Colors.Lime);
                seat4 = 1;
            }
            else if (seat4 == 1)
            {
                button4.Foreground = new SolidColorBrush(Colors.White);
                button4.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                seat4 = 0;
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (seat5 == 0)
            {
                button5.Foreground = new SolidColorBrush(Colors.Lime);
                button5.BorderBrush = new SolidColorBrush(Colors.Lime);
                seat5 = 1;
            }
            else if (seat5 == 1)
            {
                button5.Foreground = new SolidColorBrush(Colors.White);
                button5.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                seat5 = 0;
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (seat6 == 0)
            {
                button6.Foreground = new SolidColorBrush(Colors.Lime);
                button6.BorderBrush = new SolidColorBrush(Colors.Lime);
                seat6 = 1;
            }
            else if (seat6 == 1)
            {
                button6.Foreground = new SolidColorBrush(Colors.White);
                button6.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                seat6 = 0;
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (seat7 == 0)
            {
                button7.Foreground = new SolidColorBrush(Colors.Lime);
                button7.BorderBrush = new SolidColorBrush(Colors.Lime);
                seat7 = 1;
            }
            else if (seat7 == 1)
            {
                button7.Foreground = new SolidColorBrush(Colors.White);
                button7.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                seat7 = 0;
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (seat8 == 0)
            {
                button8.Foreground = new SolidColorBrush(Colors.Lime);
                button8.BorderBrush = new SolidColorBrush(Colors.Lime);
                seat8 = 1;
            }
            else if (seat8 == 1)
            {
                button8.Foreground = new SolidColorBrush(Colors.White);
                button8.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                seat8 = 0;
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (seat9 == 0)
            {
                button9.Foreground = new SolidColorBrush(Colors.Lime);
                button9.BorderBrush = new SolidColorBrush(Colors.Lime);
                seat9 = 1;
            }
            else if (seat9 == 1)
            {
                button9.Foreground = new SolidColorBrush(Colors.White);
                button9.BorderBrush = new SolidColorBrush(Color.FromRgb(112, 112, 112));
                seat9 = 0;
            }
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            ablak2 ablak2 = new ablak2();
            ablak2.Show();
            Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (seat1 == 1)
            {
                FileStream f = new FileStream("seats.txt", FileMode.Append);
                StreamWriter ir = new StreamWriter(f);
                ir.WriteLine(1);
                ir.Close();
                f.Close();
            }
            if (seat2 == 1)
            {
                FileStream f = new FileStream("seats.txt", FileMode.Append);
                StreamWriter ir = new StreamWriter(f);
                ir.WriteLine(2);
                ir.Close();
                f.Close();
            }
            if (seat3 == 1)
            {
                FileStream f = new FileStream("seats.txt", FileMode.Append);
                StreamWriter ir = new StreamWriter(f);
                ir.WriteLine(3);
                ir.Close();
                f.Close();
            }
            if (seat4 == 1)
            {
                FileStream f = new FileStream("seats.txt", FileMode.Append);
                StreamWriter ir = new StreamWriter(f);
                ir.WriteLine(4);
                ir.Close();
                f.Close();
            }
            if (seat5 == 1)
            {
                FileStream f = new FileStream("seats.txt", FileMode.Append);
                StreamWriter ir = new StreamWriter(f);
                ir.WriteLine(5);
                ir.Close();
                f.Close();
            }
            if (seat6 == 1)
            {
                FileStream f = new FileStream("seats.txt", FileMode.Append);
                StreamWriter ir = new StreamWriter(f);
                ir.WriteLine(6);
                ir.Close();
                f.Close();
            }
            if (seat7 == 1)
            {
                FileStream f = new FileStream("seats.txt", FileMode.Append);
                StreamWriter ir = new StreamWriter(f);
                ir.WriteLine(7);
                ir.Close();
                f.Close();
            }
            if (seat8 == 1)
            {
                FileStream f = new FileStream("seats.txt", FileMode.Append);
                StreamWriter ir = new StreamWriter(f);
                ir.WriteLine(8);
                ir.Close();
                f.Close();
            }
            if (seat9 == 1)
            {
                FileStream f = new FileStream("seats.txt", FileMode.Append);
                StreamWriter ir = new StreamWriter(f);
                ir.WriteLine(9);
                ir.Close();
                f.Close();
            }
            ablak2 ablak2 = new ablak2();
            MessageBox.Show("Kösöznjük a vásárlást!");
            ablak2.Show();
            Close();
        }
    }
}
