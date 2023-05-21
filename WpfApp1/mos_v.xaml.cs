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
        int o = 0;
        int v = 0;

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
        private void ch_Winner()
        {
            if (o == 11)
            {
                Winner popup = new Winner();
                popup.ShowDialog();
            }
        }
        private void P_ot1_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            p_b.Value = o;
            v++;
            P_ot1.Foreground = Brushes.Green;
            n_ot1.Foreground = Brushes.Red;
            n_ot2.Foreground = Brushes.Red;
            n_ot1.IsEnabled = false;
            n_ot2.IsEnabled = false;
            P_ot1.IsEnabled = false;
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void n_ot1_Checked(object sender, RoutedEventArgs e)
        {
            n_ot1.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void n_ot2_Checked(object sender, RoutedEventArgs e)
        {
            n_ot2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void n_ot3_Checked(object sender, RoutedEventArgs e)
        {
            n_ot3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void P_ot2_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            p_b.Value = o;
            v++;
            P_ot2.Foreground = Brushes.Green;
            n_ot3.Foreground = Brushes.Red;
            n_ot4.Foreground = Brushes.Red;
            n_ot3.IsEnabled = false;
            n_ot4.IsEnabled = false;
            P_ot2.IsEnabled = false;
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }
        int v_ch = 0;
        private void n_ot4_Checked(object sender, RoutedEventArgs e)
        {
            n_ot4.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void c_b_p1_Checked(object sender, RoutedEventArgs e)
        {
            c_b_p1.Foreground = Brushes.Green;
            v_ch++;
            o++;
            p_b.Value = o;
            if (v_ch == 5)
            {
                c_b_p1.IsEnabled = false;
                c_b_p2.IsEnabled = false;
                c_b_p3.IsEnabled = false;
                c_b_p4.IsEnabled = false;
                c_b_p5.IsEnabled = false;
                c_b_n1.IsEnabled = false;
                c_b_n1.Foreground = Brushes.Red;
                v++;
            }
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void c_b_p2_Checked(object sender, RoutedEventArgs e)
        {
            c_b_p2.Foreground = Brushes.Green;
            v_ch++;
            o++;
            p_b.Value = o;
            if (v_ch == 5)
            {
                c_b_p1.IsEnabled = false;
                c_b_p2.IsEnabled = false;
                c_b_p3.IsEnabled = false;
                c_b_p4.IsEnabled = false;
                c_b_p5.IsEnabled = false;
                c_b_n1.IsEnabled = false;
                c_b_n1.Foreground = Brushes.Red;
                v++;
            }
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void c_b_p3_Checked(object sender, RoutedEventArgs e)
        {
            c_b_p3.Foreground = Brushes.Green;
            v_ch++;
            o++;
            p_b.Value = o;
            if (v_ch == 5)
            {
                c_b_p1.IsEnabled = false;
                c_b_p2.IsEnabled = false;
                c_b_p3.IsEnabled = false;
                c_b_p4.IsEnabled = false;
                c_b_p5.IsEnabled = false;
                c_b_n1.IsEnabled = false;
                c_b_n1.Foreground = Brushes.Red;
                v++;
            }
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void c_b_p4_Checked(object sender, RoutedEventArgs e)
        {
            c_b_p4.Foreground = Brushes.Green;
            v_ch++;
            o++;
            p_b.Value = o;
            if (v_ch == 5)
            {
                c_b_p1.IsEnabled = false;
                c_b_p2.IsEnabled = false;
                c_b_p3.IsEnabled = false;
                c_b_p4.IsEnabled = false;
                c_b_p5.IsEnabled = false;
                c_b_n1.IsEnabled = false;
                c_b_n1.Foreground = Brushes.Red;
                v++;
            }
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void c_b_p5_Checked(object sender, RoutedEventArgs e)
        {
            c_b_p5.Foreground = Brushes.Green;
            v_ch++;
            o++;
            p_b.Value = o;
            if (v_ch == 5)
            {
                c_b_p1.IsEnabled = false;
                c_b_p2.IsEnabled = false;
                c_b_p3.IsEnabled = false;
                c_b_p4.IsEnabled = false;
                c_b_p5.IsEnabled = false;
                c_b_n1.IsEnabled = false;
                c_b_n1.Foreground = Brushes.Red;
                v++;
            }
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void c_b_n1_Checked(object sender, RoutedEventArgs e)
        {
            c_b_n1.Foreground = Brushes.Red;
            if (v_ch == 5)
            {
                c_b_p1.IsEnabled = false;
                c_b_p2.IsEnabled = false;
                c_b_p3.IsEnabled = false;
                c_b_p4.IsEnabled = false;
                c_b_p5.IsEnabled = false;
                c_b_n1.IsEnabled = false;
                c_b_n1.Foreground = Brushes.Red;
                v++;
            }
            if (v == 3)
            {
                Level2.IsEnabled = true;
                v = 0;
            }
            ch_Winner();
        }

        private void v3_rb1_Checked(object sender, RoutedEventArgs e)
        {
            v3_rb1.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v3_rb2_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            p_b.Value = o;
            v++;
            v3_rb2.Foreground = Brushes.Green;
            v3_rb1.Foreground = Brushes.Red;
            v3_rb1.IsEnabled = false;
            v3_rb2.IsEnabled = false;
            ch_Winner();
        }

        private void v4_rb1_Checked(object sender, RoutedEventArgs e)
        {
            v4_rb1.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v4_rb2_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            p_b.Value = o;
            v++;
            v4_rb2.Foreground = Brushes.Green;
            v4_rb1.Foreground = Brushes.Red;
            v4_rb3.Foreground = Brushes.Red;
            v4_rb4.Foreground = Brushes.Red;
            v4_rb1.IsEnabled = false;
            v4_rb2.IsEnabled = false;
            v4_rb3.IsEnabled = false;
            v4_rb4.IsEnabled = false;
            ch_Winner();
        }

        private void v4_rb3_Checked(object sender, RoutedEventArgs e)
        {
            v4_rb3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v4_rb4_Checked(object sender, RoutedEventArgs e)
        {
            v4_rb4.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v5_rb1_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            p_b.Value = o;
            v++;
            v5_rb1.Foreground = Brushes.Green;
            v5_rb2.Foreground = Brushes.Red;
            v5_rb3.Foreground = Brushes.Red;
            v5_rb1.IsEnabled = false;
            v5_rb2.IsEnabled = false;
            v5_rb3.IsEnabled = false;
            ch_Winner();
        }

        private void v5_rb2_Checked(object sender, RoutedEventArgs e)
        {
            v5_rb2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v5_rb3_Checked(object sender, RoutedEventArgs e)
        {
            v5_rb3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v6_rb1_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            p_b.Value = o;
            v++;
            v6_rb1.Foreground = Brushes.Green;
            v6_rb2.Foreground = Brushes.Red;
            v6_rb3.Foreground = Brushes.Red;
            v6_rb1.IsEnabled = false;
            v6_rb2.IsEnabled = false;
            v6_rb3.IsEnabled = false;
            ch_Winner();
        }

        private void v6_rb2_Checked(object sender, RoutedEventArgs e)
        {
            v6_rb2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v6_rb3_Checked(object sender, RoutedEventArgs e)
        {
            v6_rb3.Foreground = Brushes.Red;
            ch_Winner();
        }
    }
}
