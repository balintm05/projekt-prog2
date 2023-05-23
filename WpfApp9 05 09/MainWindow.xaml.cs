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

namespace WpfApp9_05_09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> users_names = new List<string> { };
        List<string> users = new List<string> { };
        List<string> passwords = new List<string> { };
        public int settings = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBox.Text = comboBox.SelectedItem.ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (users.Contains(textBox.Text)==false && checkBox.IsChecked==true)
                {
                users.Add(textBox.Text);
                comboBox.Items.Add(textBox.Text);
                listBox.Items.Add(textBox.Text);
                }

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i]==textBox.Text)
                {
                    if (passwords[i]==passwordBox.Password)
                    {
                        label5.Content = "Sikeres bejelentkezés";
                    }
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
           
            if (settings==0)
            {
                Application.Current.MainWindow.Height = 280;
                Application.Current.MainWindow.Width = 400;
                button2.Margin = new Thickness(103, 200, 0, 0);
                textBox.Visibility = Visibility.Hidden;
                comboBox.Visibility = Visibility.Hidden;
                passwordBox.Visibility = Visibility.Hidden;
                label.Visibility = Visibility.Hidden;
                label1.Visibility = Visibility.Hidden;
                button.Visibility = Visibility.Hidden;
                button1.Visibility = Visibility.Hidden;
                checkBox.Visibility = Visibility.Hidden;
                button2.Content = "Vissza";
                settings = 1;
                //Beállítások//
                button3.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label3.Visibility = Visibility.Visible;
                checkBox1.Visibility = Visibility.Visible;
            }
            else if (settings==1)
            {
                Application.Current.MainWindow.Height = 250;
                Application.Current.MainWindow.Width = 400;
                button2.Margin = new Thickness(103, 169, 0, 0);
                button2.Content = "Beállítások";
                textBox.Visibility = Visibility.Visible;
                comboBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Visible;
                label.Visibility = Visibility.Visible;
                label1.Visibility = Visibility.Visible;
                button.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Visible;
                checkBox.Visibility = Visibility.Visible;
                settings = 0;
                //Beállítások//
                button3.Visibility = Visibility.Hidden;
                label2.Visibility = Visibility.Hidden;
                label3.Visibility = Visibility.Hidden;
                checkBox1.Visibility = Visibility.Hidden;
            }
            else if (settings == 2)
            {
                settings = 1;
                button3.Visibility = Visibility.Visible;
                label2.Visibility = Visibility.Visible;
                label3.Visibility = Visibility.Visible;
                checkBox1.Visibility = Visibility.Visible;

                listBox.Visibility = Visibility.Hidden;
                button4.Visibility = Visibility.Hidden;

            }
            else if (settings == 4)
            {
                textBox.Visibility = Visibility.Visible;
                comboBox.Visibility = Visibility.Visible;
                passwordBox.Visibility = Visibility.Visible;
                button.Visibility = Visibility.Visible;
                button1.Visibility = Visibility.Visible;
                button2.Visibility = Visibility.Visible;
                checkBox.Visibility = Visibility.Visible;
                button2.Content = "Beállítások";
                settings = 0;
                //Regisztráció//
                label4.Visibility = Visibility.Hidden;
                passwordBox1.Visibility = Visibility.Hidden;
                textBox1.Visibility = Visibility.Hidden;
            }
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            button3.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            listBox.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            label3.Visibility = Visibility.Hidden;
            checkBox1.Visibility = Visibility.Hidden;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            button3.Visibility = Visibility.Hidden;
            label2.Visibility = Visibility.Hidden;
            settings = 2;
            listBox.Visibility = Visibility.Visible;
            button4.Visibility = Visibility.Visible;
            label3.Visibility = Visibility.Hidden;
            checkBox1.Visibility = Visibility.Hidden;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i]==listBox.SelectedItem)
                {
                    users.Remove(users[i]);
                    comboBox.Items.Remove(listBox.SelectedItem);
                }
            }
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            button.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            button1.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            button2.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            button3.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            button4.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            ablak.Background = new SolidColorBrush(Color.FromRgb(47, 49, 54));
            listBox.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            comboBox.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            textBox.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            passwordBox.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            checkBox.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));
            checkBox1.Background = new SolidColorBrush(Color.FromRgb(73, 76, 81));

            button.Foreground = new SolidColorBrush(Colors.White);
            button1.Foreground = new SolidColorBrush(Colors.White);
            button2.Foreground = new SolidColorBrush(Colors.White);
            button3.Foreground = new SolidColorBrush(Colors.White);
            button4.Foreground = new SolidColorBrush(Colors.White);
            listBox.Foreground = new SolidColorBrush(Colors.White);
            comboBox.Foreground = new SolidColorBrush(Colors.White);
            textBox.Foreground = new SolidColorBrush(Colors.White);
            passwordBox.Foreground = new SolidColorBrush(Colors.White);
            label.Foreground = new SolidColorBrush(Colors.White);
            label1.Foreground = new SolidColorBrush(Colors.White);
            label2.Foreground = new SolidColorBrush(Colors.White);
            label3.Foreground = new SolidColorBrush(Colors.White);
            checkBox.Foreground = new SolidColorBrush(Colors.White);
            checkBox1.Foreground = new SolidColorBrush(Colors.White);
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            button.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            button1.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            button2.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            button3.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            button4.Background = new SolidColorBrush(Color.FromRgb(221, 221, 221));
            ablak.Background = new SolidColorBrush(Colors.White);
            listBox.Background = new SolidColorBrush(Colors.White);
            comboBox.Background = new SolidColorBrush(Colors.White);
            textBox.Background = new SolidColorBrush(Colors.White);
            passwordBox.Background = new SolidColorBrush(Colors.White);
            checkBox.Background = new SolidColorBrush(Colors.White);
            checkBox1.Background = new SolidColorBrush(Colors.White);


            button.Foreground = new SolidColorBrush(Colors.Black);
            button1.Foreground = new SolidColorBrush(Colors.Black);
            button2.Foreground = new SolidColorBrush(Colors.Black);
            button3.Foreground = new SolidColorBrush(Colors.Black);
            button4.Foreground = new SolidColorBrush(Colors.Black);
            listBox.Foreground = new SolidColorBrush(Colors.Black);
            comboBox.Foreground = new SolidColorBrush(Colors.Black);
            textBox.Foreground = new SolidColorBrush(Colors.Black);
            passwordBox.Foreground = new SolidColorBrush(Colors.Black);
            label.Foreground = new SolidColorBrush(Colors.Black);
            label1.Foreground = new SolidColorBrush(Colors.Black);
            label2.Foreground = new SolidColorBrush(Colors.Black);
            label3.Foreground = new SolidColorBrush(Colors.Black);
            checkBox.Foreground = new SolidColorBrush(Colors.Black);
            checkBox1.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            /*string pass = passwordBox.Password;
            if (passwordBox.Password.Length < 3)
            {
                passwordBox.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            else
            {
                passwordBox.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
            }*/
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (settings==0)
            {
                textBox.Visibility = Visibility.Hidden;
                comboBox.Visibility = Visibility.Hidden;
                passwordBox.Visibility = Visibility.Hidden;
                button.Visibility = Visibility.Hidden;
                button1.Visibility = Visibility.Hidden;
                checkBox.Visibility = Visibility.Hidden;
                button2.Content = "Vissza";
                settings = 4;
                //Regisztrácó//
                passwordBox1.Visibility = Visibility.Visible;
                textBox1.Visibility = Visibility.Visible;
            }
            else if (settings==4)
            {
                textBox1.BorderBrush = new SolidColorBrush(Colors.Gray);
                passwordBox1.BorderBrush = new SolidColorBrush(Colors.Gray);
                label4.Visibility = Visibility.Hidden;
                if (textBox1.Text.Length>=3)
                {
                    if (passwordBox1.Password.Length >= 3)
                    {
                        users.Add(textBox1.Text);
                        passwords.Add(passwordBox1.Password);
                        
                    }
                    else
                    {
                        label4.Visibility = Visibility.Visible;
                        passwordBox1.BorderBrush = new SolidColorBrush(Colors.Red);
                        label4.Content = "A jelszónak legalább 3 karakterből kell állnia.";
                    }
                }
                else
                {
                    if (passwordBox1.Password.Length < 3)
                    {
                        passwordBox1.BorderBrush = new SolidColorBrush(Colors.Red);
                    }
                    textBox1.BorderBrush=new SolidColorBrush(Colors.Red);
                    label4.Visibility = Visibility.Visible;
                    label4.Content = "A felhasználónévnek legalább 3 karakterből kell állnia.";
                }
                
                
            }
            
        }
    }
}
