using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для mos_v.xaml
    /// </summary>
    public partial class mos_v : Window
    {
        public mos_v()
        {
            InitializeComponent();

        }
        int k = 0;
        bool p1 = false;
        bool p2 = false;
        private void P_ot1_Checked(object sender, RoutedEventArgs e)
        {
            k++;
            p_b.Value = k;
            P_ot1.Foreground = Brushes.Green;
            P_ot1.IsEnabled= false;
            n_ot1.IsEnabled= false;
            n_ot2.IsEnabled= false;
            p1 = true;
        }

        private void P_ot2_Checked(object sender, RoutedEventArgs e)
        {
            k++;
            p_b.Value = k;
            P_ot2.Foreground = Brushes.Green;
            P_ot2.IsEnabled = false;
            n_ot3.IsEnabled = false;
            n_ot4.IsEnabled = false;
            p1 = true;
        }

        private void n_ot1_Checked(object sender, RoutedEventArgs e)
        {
            n_ot1.Foreground = Brushes.Red;
            p1 = false;
        }

        private void n_ot2_Checked(object sender, RoutedEventArgs e)
        {
            n_ot2.Foreground = Brushes.Red;
            p1 = false;
        }

        private void n_ot3_Checked(object sender, RoutedEventArgs e)
        {
            n_ot3.Foreground = Brushes.Red;
            p1 = false;
        }

        private void n_ot4_Checked(object sender, RoutedEventArgs e)
        {
            n_ot4.Foreground = Brushes.Red;
            p1 = false;
        }

        private void Button_Click_btn_p1(object sender, RoutedEventArgs e)
        {
            if (c_b_p1.IsChecked == true && c_b_p2.IsChecked == true && c_b_p3.IsChecked == true && c_b_p3.IsChecked == true && c_b_p4.IsChecked == true && c_b_p5.IsChecked == true && c_b_n1.IsChecked == false)
            {
                c_b_p1.IsEnabled = false;
                c_b_p2.IsEnabled = false;
                c_b_p3.IsEnabled = false;
                c_b_p4.IsEnabled = false;
                c_b_p5.IsEnabled = false;
                c_b_n1.IsEnabled = false;
                btn_p1.IsEnabled = false;
                c_b_p1.Foreground = Brushes.Green;
                c_b_p2.Foreground = Brushes.Green;
                c_b_p3.Foreground = Brushes.Green;
                c_b_p4.Foreground = Brushes.Green;
                c_b_p5.Foreground = Brushes.Green;
                c_b_n1.Foreground = Brushes.Red;
                k = k + 3;
                p_b.Value = k;
                p1 = true;
            }
            else
            {
                p1 = false;
                c_b_p1.IsChecked = false;
                c_b_p2.IsChecked = false;
                c_b_p3.IsChecked = false;
                c_b_p4.IsChecked = false;
                c_b_p5.IsChecked = false;
                c_b_n1.IsChecked = false;
            }
        if (p1 == true)
            {
                la1.Visibility= Visibility.Visible;
                Level2.IsEnabled= true;
                p1= false;
            }

        }

        private void v3_rb1_Checked(object sender, RoutedEventArgs e)
        {
            v3_rb1.Foreground = Brushes.Red;
            p2 = false;
        }

        private void v3_rb2_Checked(object sender, RoutedEventArgs e)
        {
            v3_rb2.Foreground = Brushes.Green;
            v3_rb1.IsEnabled = false;
            v3_rb2.IsEnabled= false;
            p2 = true;
            k++;
            p_b.Value = k;
        }

        private void v4_rb1_Checked(object sender, RoutedEventArgs e)
        {
            v4_rb1.Foreground = Brushes.Red;
            p2 = false;
        }

        private void v4_rb2_Checked(object sender, RoutedEventArgs e)
        {
            p2 = true;
            v4_rb2.Foreground= Brushes.Green;
            v4_rb1.IsEnabled = false;
            v4_rb2.IsEnabled= false;
            v4_rb3.IsEnabled = false;
            v4_rb4.IsEnabled = false;
            k++;
            p_b.Value = k;

        }

        private void v4_rb3_Checked(object sender, RoutedEventArgs e)
        {
            p2 = false;
            v4_rb3.Foreground = Brushes.Red;
        }

        private void v4_rb4_Checked(object sender, RoutedEventArgs e)
        {
            p2 = false;
            v4_rb4.Foreground = Brushes.Red;
        }

        private void v5_rb1_Checked(object sender, RoutedEventArgs e)
        {
            p2 = true;
            k++;
            p_b.Value = k;
            v5_rb1.Foreground = Brushes.Green;
            v5_rb1.IsEnabled = false;
            v5_rb2.IsEnabled = false;
            v5_rb3.IsEnabled = false;
        }

        private void v5_rb2_Checked(object sender, RoutedEventArgs e)
        {
            p2 = false;
            v5_rb2.Foreground = Brushes.Red;
        }

        private void v5_rb3_Checked(object sender, RoutedEventArgs e)
        {
            p2 = false;
            v5_rb3.Foreground = Brushes.Red;
        }

        private void v6_rb1_Checked(object sender, RoutedEventArgs e)
        {
            p2 = true;
            k++;
            p_b.Value = k;
            v6_rb1.Foreground = Brushes.Green;
            v6_rb1.IsEnabled = false;
            v6_rb2.IsEnabled = false;
            v6_rb3.IsEnabled = false;
        }

        private void v6_rb2_Checked(object sender, RoutedEventArgs e)
        {
            p2 = false;
            v6_rb2.Foreground = Brushes.Red;
        }

        private void v6_rb3_Checked(object sender, RoutedEventArgs e)
        {
            p2 = false;
            v6_rb3.Foreground = Brushes.Red;
        }

        private void btn_p2_Click(object sender, RoutedEventArgs e)
        {
            if (p2 == true)
            {
                la2.Visibility = Visibility.Visible;
                Level3.IsEnabled = true;
                p2 = false;
            }
        }

        private void re_Click(object sender, RoutedEventArgs e)
        {
            mos_b_window win2 = new mos_b_window();
            win2.Show();
            Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            Event_Selection win2 = new Event_Selection();
            win2.Show();
            Close();
        }
    }
}
