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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для kr_b_v.xaml
    /// </summary>
    public partial class kr_b_v : Window
    {
        public kr_b_v()
        {
            InitializeComponent();
        }
        int o = 0;
        int v= 0;
        private void v1_l1_Checked(object sender, RoutedEventArgs e)
        {
            v1_l1.Foreground = Brushes.Red;
        }

        private void v2_l1_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            p_b.Value = o;
            v++;
            v1_l1.Foreground = Brushes.Red;
            v2_l1.Foreground = Brushes.Green;
            v3_l1.Foreground = Brushes.Red;
            v4_l1.Foreground = Brushes.Red;
            v1_l1.IsEnabled = false;
            v2_l1.IsEnabled = false;
            v3_l1.IsEnabled = false;
            v4_l1.IsEnabled = false;    
        }

        private void v3_l1_Checked(object sender, RoutedEventArgs e)
        {
            v3_l1.Foreground = Brushes.Red;
        }

        private void v4_l1_Checked(object sender, RoutedEventArgs e)
        {
            v4_l1.Foreground = Brushes.Red;
        }

        private void v5_l1_Checked(object sender, RoutedEventArgs e)
        {
            v5_l1.Foreground = Brushes.Red;
        }

        private void v6_l1_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            p_b.Value = o;
            v++;
            v6_l1.Foreground = Brushes.Green;
            v5_l1.Foreground = Brushes.Red;
            v7_l1.Foreground = Brushes.Red;
            v8_l1.Foreground = Brushes.Red;
            v5_l1.IsEnabled = false;
            v6_l1.IsEnabled = false;
            v7_l1.IsEnabled = false;
            v8_l1.IsEnabled = false;
        }

        private void v7_l1_Checked(object sender, RoutedEventArgs e)
        {
            v7_l1.Foreground = Brushes.Red;
        }

        private void v8_l1_Checked(object sender, RoutedEventArgs e)
        {
            v8_l1.Foreground = Brushes.Red;
        }

        private void v9_l1_Checked(object sender, RoutedEventArgs e)
        {
            v9_l1.Foreground = Brushes.Red;
        }

        private void v10_l1_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            p_b.Value = o;
            v++;
            v10_l1.Foreground = Brushes.Green;
            v9_l1.Foreground = Brushes.Red;
            v11_l1.Foreground = Brushes.Red;
            v12_l1.Foreground = Brushes.Red;
            v10_l1.IsEnabled = false;
            v9_l1.IsEnabled = false;
            v11_l1.IsEnabled = false;
            v12_l1.IsEnabled = false;
        }

        private void v11_l1_Checked(object sender, RoutedEventArgs e)
        {
            v11_l1.Foreground = Brushes.Red;
        }

        private void v12_l1_Checked(object sender, RoutedEventArgs e)
        {
            v12_l1.Foreground = Brushes.Red;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            if (v == 3)
            {
                Level2.IsEnabled = true;
            }
            else
            {

            }
        }

        private void v1_l2_Checked(object sender, RoutedEventArgs e)
        {
            v1_l2.Foreground = Brushes.Red;
        }

        private void v2_l2_Checked(object sender, RoutedEventArgs e)
        {
            v2_l2.Foreground = Brushes.Red;
        }

        private void v3_l2_Checked(object sender, RoutedEventArgs e)
        {
            v3_l2.Foreground = Brushes.Green;
            v4_l2.IsEnabled = false;
            v1_l2.IsEnabled = false;
            v2_l2.IsEnabled = false;
            v3_l2.IsEnabled = false;
            v4_l2.Foreground = Brushes.Red;
            v2_l2.Foreground = Brushes.Red;
            v1_l2.Foreground = Brushes.Red;
        }

        private void v4_l2_Checked(object sender, RoutedEventArgs e)
        {
            v4_l2.Foreground = Brushes.Red;    
        }

        private void v5_l2_Checked(object sender, RoutedEventArgs e)
        {
            v5_l2.Foreground = Brushes.Green;
            v5_l2.IsEnabled = false;
            v6_l2.IsEnabled = false;
            v7_l2.IsEnabled = false;
            v8_l2.IsEnabled = false;
            v6_l2.Foreground = Brushes.Red;
            v7_l2.Foreground = Brushes.Red;
            v8_l2.Foreground = Brushes.Red;
        }

        private void v6_l2_Checked(object sender, RoutedEventArgs e)
        {
            v6_l2.Foreground = Brushes.Red;
        }

        private void v7_l2_Checked(object sender, RoutedEventArgs e)
        {
            v7_l2.Foreground = Brushes.Red;
        }

        private void v8_l2_Checked(object sender, RoutedEventArgs e)
        {
            v8_l2.Foreground = Brushes.Red;
        }
    }
}
