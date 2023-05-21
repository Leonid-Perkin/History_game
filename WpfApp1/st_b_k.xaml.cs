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
    /// Логика взаимодействия для st_b_k.xaml
    /// </summary>
    public partial class st_b_k : Window
    {
        public st_b_k()
        {
            InitializeComponent();
        }

        int o = 0;
        private void ch_Winner()
        {
            if (o == 3)
            {
                Winner popup = new Winner();
                popup.ShowDialog();
            }
        }
        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb1.Text == "Сталинград")
            {
                o++;
                p_b.Value = o;
                tb1.Background = Brushes.Green;
                tb1.Foreground = Brushes.White;
                tb1.IsEnabled = false;
                ch_Winner();
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb2.Text == "Калач-на-Дону"|| tb2.Text == "Калач на Дону")
            {
                o++;
                p_b.Value = o;
                tb2.Background = Brushes.Green;
                tb2.Foreground = Brushes.White;
                tb2.IsEnabled = false;
                ch_Winner();
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (tb3.Text == "коренной перелом")
            {
                o++;
                p_b.Value = o;
                tb3.Background = Brushes.Green;
                tb3.Foreground = Brushes.White;
                tb3.IsEnabled = false;
                ch_Winner();
            }
        }
    }
}
