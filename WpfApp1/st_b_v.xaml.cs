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
    /// Логика взаимодействия для st_b_v.xaml
    /// </summary>
    public partial class st_b_v : Window
    {
        public st_b_v()
        {
            InitializeComponent();
        }
        private void re_Click(object sender, RoutedEventArgs e)
        {
            st_window win2 = new st_window();
            win2.Show();
            Close();
        }

        private void home_Click(object sender, RoutedEventArgs e)
        {
            Event_Selection win2 = new Event_Selection();
            win2.Show();
            Close();
        }
        int o = 0;
        int v = 0;
        private void ch_Winner()
        {
            if (o == 8)
            {
                Winner popup = new Winner();
                popup.ShowDialog();
            }
        }
        private void ot1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ot1.Text == "Волгограде"|| ot1.Text == "в Волгограде")
            {
                o++;
                ot1.Background = Brushes.Green;
                ot1.Foreground = Brushes.White;
                ot1.IsEnabled = false;
                p_b.Value = o;
                v++;
                if (v == 6)
                {
                    l2.IsEnabled = true;
                }
                ch_Winner();
            }
        }

        private void ot2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ot2.Text == "Сталинградской битвы" || ot2.Text == "сталинградской битвы")
            {
                o++;
                ot2.Background = Brushes.Green;
                ot2.Foreground = Brushes.White;
                ot2.IsEnabled = false;
                p_b.Value = o;
                v++;
                if (v == 6)
                {
                    l2.IsEnabled = true;
                }
                ch_Winner();
            }
        }

        private void ot3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ot3.Text == "Сталинград" || ot3.Text == "сталинград")
            {
                o++;
                ot3.Background = Brushes.Green;
                ot3.Foreground = Brushes.White;
                ot3.IsEnabled = false;
                p_b.Value = o;
                v++;
                if (v == 6)
                {
                    l2.IsEnabled = true;
                }
                ch_Winner();
            }
        }

        private void ot4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ot4.Text == "Дом Павлова" || ot4.Text == "дом Павлова")
            {
                o++;
                ot4.Background = Brushes.Green;
                ot4.Foreground = Brushes.White;
                ot4.IsEnabled = false;
                p_b.Value = o;
                v++;
                if (v == 6)
                {
                    l2.IsEnabled = true;
                }
                ch_Winner();
            }
        }

        private void ot5_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ot5.Text == "А.М.Василевский" || ot5.Text == "Василевский")
            {
                o++;
                ot5.Background = Brushes.Green;
                ot5.Foreground = Brushes.White;
                ot5.IsEnabled = false;
                p_b.Value = o;
                v++;
                if (v == 6)
                {
                    l2.IsEnabled = true;
                }
                ch_Winner();
            }
        }

        private void ot6_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ot6.Text == "Жуков" || ot6.Text == "Г.К.Жуков")
            {
                o++;
                ot6.Background = Brushes.Green;
                ot6.Foreground = Brushes.White;
                ot6.IsEnabled = false;
                p_b.Value = o;
                v++;
                if (v == 6)
                {
                    l2.IsEnabled = true;
                }
                ch_Winner();
            }
        }

        private void ot7_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ot7.Text == "321")
            {
                o++;
                ot7.Background = Brushes.Green;
                ot7.Foreground = Brushes.White;
                ot7.IsEnabled = false;
                p_b.Value = o;
                l3.IsEnabled = true;
                ch_Winner();
            }
        }

        private void v1_Checked(object sender, RoutedEventArgs e)
        {
            o++;
            v1.Foreground = Brushes.Green;
            v2.Foreground = Brushes.Red;
            v3.Foreground = Brushes.Red;
            v4.Foreground = Brushes.Red;
            v1.IsEnabled = false;
            v2.IsEnabled = false;
            v3.IsEnabled = false;
            v4.IsEnabled = false;
            p_b.Value = o;
            ch_Winner();
        }

        private void v2_Checked(object sender, RoutedEventArgs e)
        {
            v2.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v3_Checked(object sender, RoutedEventArgs e)
        {
            v3.Foreground = Brushes.Red;
            ch_Winner();
        }

        private void v4_Checked(object sender, RoutedEventArgs e)
        {
            v4.Foreground = Brushes.Red;
            ch_Winner();
        }
    }
}
