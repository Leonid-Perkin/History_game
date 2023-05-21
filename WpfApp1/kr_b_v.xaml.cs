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
            ch_Winner();
        }

        private void ch_Winner()
        {
            if (o == 14)
            {
                Winner popup = new Winner();
                popup.ShowDialog();
            }
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
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v3_l1_Checked(object sender, RoutedEventArgs e)
        {
            v3_l1.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v4_l1_Checked(object sender, RoutedEventArgs e)
        {
            v4_l1.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v5_l1_Checked(object sender, RoutedEventArgs e)
        {
            v5_l1.Foreground = Brushes.Red;
            ch_Winner();
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
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v7_l1_Checked(object sender, RoutedEventArgs e)
        {
            v7_l1.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v8_l1_Checked(object sender, RoutedEventArgs e)
        {
            v8_l1.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v9_l1_Checked(object sender, RoutedEventArgs e)
        {
            v9_l1.Foreground = Brushes.Red;
            ch_Winner();
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
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v11_l1_Checked(object sender, RoutedEventArgs e)
        {
            v11_l1.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v12_l1_Checked(object sender, RoutedEventArgs e)
        {
            v12_l1.Foreground = Brushes.Red;
            ch_Winner();
        }
        private void v1_l2_Checked(object sender, RoutedEventArgs e)
        {
            v1_l2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v2_l2_Checked(object sender, RoutedEventArgs e)
        {
            v2_l2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v3_l2_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v3_l2.Foreground = Brushes.Green;
            v4_l2.IsEnabled = false;
            v1_l2.IsEnabled = false;
            v2_l2.IsEnabled = false;
            v3_l2.IsEnabled = false;
            v4_l2.Foreground = Brushes.Red;
            v2_l2.Foreground = Brushes.Red;
            v1_l2.Foreground = Brushes.Red;
            if (v == 3)
            {
                Level3.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v4_l2_Checked(object sender, RoutedEventArgs e)
        {
            v4_l2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v5_l2_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v5_l2.Foreground = Brushes.Green;
            v5_l2.IsEnabled = false;
            v6_l2.IsEnabled = false;
            v7_l2.IsEnabled = false;
            v8_l2.IsEnabled = false;
            v6_l2.Foreground = Brushes.Red;
            v7_l2.Foreground = Brushes.Red;
            v8_l2.Foreground = Brushes.Red;
            if (v == 3)
            {
                Level3.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v6_l2_Checked(object sender, RoutedEventArgs e)
        {
            v6_l2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v7_l2_Checked(object sender, RoutedEventArgs e)
        {
            v7_l2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v8_l2_Checked(object sender, RoutedEventArgs e)
        {
            v8_l2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v10_l2_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v10_l2.Foreground = Brushes.Green;
            v9_l2.Foreground = Brushes.Red;
            v11_l2.Foreground = Brushes.Red;
            v12_l2.Foreground = Brushes.Red;
            v9_l2.IsEnabled = false;
            v10_l2.IsEnabled = false;
            v11_l2.IsEnabled = false;
            v12_l2.IsEnabled = false;
            if (v == 3)
            {
                Level3.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v9_l2_Checked(object sender, RoutedEventArgs e)
        {
            v9_l2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v11_l2_Checked(object sender, RoutedEventArgs e)
        {
            v11_l2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v12_l2_Checked(object sender, RoutedEventArgs e)
        {
            v12_l2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v1_l3_Checked(object sender, RoutedEventArgs e)
        {
            v1_l3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v2_l3_Checked(object sender, RoutedEventArgs e)
        {
            v2_l3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v3_l3_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v3_l3.Foreground = Brushes.Green;
            v3_l3.IsEnabled = false;
            v1_l3.IsEnabled = false;
            v2_l3.IsEnabled = false;
            v4_l3.IsEnabled = false;
            v1_l3.Foreground = Brushes.Red;
            v2_l3.Foreground = Brushes.Red;
            v4_l3.Foreground = Brushes.Red;
            if (v == 3)
            {
                Level4.IsEnabled = true;
                v = 0;
            }
            ch_Winner();

        }

        private void v4_l3_Checked(object sender, RoutedEventArgs e)
        {
            v4_l3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v5_l3_Checked(object sender, RoutedEventArgs e)
        {
            v5_l3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v6_l3_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v6_l3.Foreground = Brushes.Green;
            v5_l3.Foreground = Brushes.Red;
            v7_l3.Foreground = Brushes.Red;
            v8_l3.Foreground = Brushes.Red;
            v6_l3.IsEnabled = false;
            v7_l3.IsEnabled = false;
            v8_l3.IsEnabled = false;
            v5_l3.IsEnabled = false;
            if (v == 3)
            {
                Level4.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v7_l3_Checked(object sender, RoutedEventArgs e)
        {
            v7_l3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v8_l3_Checked(object sender, RoutedEventArgs e)
        {
            v8_l3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v9_l3_Checked(object sender, RoutedEventArgs e)
        {
            v9_l3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v10_l3_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v9_l3.Foreground = Brushes.Red;
            v11_l3.Foreground = Brushes.Red;
            v12_l3.Foreground = Brushes.Red;
            v10_l3.Foreground = Brushes.Green;
            v9_l3.IsEnabled = false;
            v11_l3.IsEnabled = false;
            v12_l3.IsEnabled = false;
            v10_l3.IsEnabled = false;
            if (v == 3)
            {
                Level4.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v11_l3_Checked(object sender, RoutedEventArgs e)
        {
            v11_l3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v12_l3_Checked(object sender, RoutedEventArgs e)
        {
            v12_l3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v1_l4_Checked(object sender, RoutedEventArgs e)
        {
            v1_l4.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v2_l4_Checked(object sender, RoutedEventArgs e)
        {
            v2_l4.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v3_l4_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v1_l4.IsEnabled = false; 
            v2_l4.IsEnabled = false;
            v3_l4.IsEnabled = false;
            v4_l4.IsEnabled = false;
            v3_l4.Foreground = Brushes.Green;
            v1_l4.Foreground = Brushes.Red;
            v2_l4.Foreground = Brushes.Red;
            v4_l4.Foreground = Brushes.Red;
            v10_l3.IsEnabled = false;
            if (v == 2)
            {
                Level5.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v4_l4_Checked(object sender, RoutedEventArgs e)
        {
            v4_l4.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v5_l4_Checked(object sender, RoutedEventArgs e)
        {
            v5_l4.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v6_l4_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v5_l4.IsEnabled = false;
            v6_l4.IsEnabled = false;
            v7_l4.IsEnabled = false;
            v8_l4.IsEnabled = false;
            v6_l4.Foreground = Brushes.Green;
            v5_l4 .Foreground = Brushes.Red;
            v7_l4 .Foreground = Brushes.Red;
            v8_l4 .Foreground = Brushes.Red;
            if (v == 2)
            {
                Level5.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v7_l4_Checked(object sender, RoutedEventArgs e)
        {
            v7_l4.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v8_l4_Checked(object sender, RoutedEventArgs e)
        {
            v8_l4.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v1_l5_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v1_l5.Foreground = Brushes.Green;
            v2_l5.Foreground = Brushes.Red;
            v3_l5.Foreground = Brushes.Red;
            v4_l5.Foreground = Brushes.Red;
            v1_l5.IsEnabled = false;
            v2_l5.IsEnabled = false;
            v3_l5.IsEnabled = false;
            v4_l5.IsEnabled = false;
            if (v == 3)
            {
                Level5.IsEnabled = true;
                v = 0;
            }
            ch_Winner();

        }

        private void v2_l5_Checked(object sender, RoutedEventArgs e)
        {
            v2_l5.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v3_l5_Checked(object sender, RoutedEventArgs e)
        {
            v3_l5.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v4_l5_Checked(object sender, RoutedEventArgs e)
        {
            v4_l5.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v5_l5_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v++;
            p_b.Value = o;
            v5_l5.Foreground = Brushes.Green;
            v6_l5.Foreground = Brushes.Red;
            v7_l5.Foreground = Brushes.Red;
            v8_l5.Foreground = Brushes.Red;
            v5_l5.IsEnabled = false;
            v6_l5.IsEnabled = false;
            v7_l5.IsEnabled = false;
            v8_l5.IsEnabled = false;
            if (v == 3)
            {
                Level5.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v6_l5_Checked(object sender, RoutedEventArgs e)
        {
            v6_l5.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v7_l5_Checked(object sender, RoutedEventArgs e)
        {
            v7_l5.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v8_l5_Checked(object sender, RoutedEventArgs e)
        {
            v8_l5.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb1.Text== "23 августа")
            {
                tb1.Background = Brushes.Green;
                tb1.Foreground = Brushes.White;
                o++;
                v++;
                p_b.Value = o;
                if (v == 3)
                {
                    Level5.IsEnabled = true;
                    v = 0;
                }

            }
            ch_Winner();
        }

        private void re_Click(object sender, RoutedEventArgs e)
        {
            kr_window win2 = new kr_window();
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
