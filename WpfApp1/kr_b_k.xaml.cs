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
    /// Логика взаимодействия для kr_b_k.xaml
    /// </summary>
    public partial class kr_b_k : Window
    {
        public kr_b_k()
        {
            InitializeComponent();
        }
        int p = 0;
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ot1.Text== "сорок четвертом")
            {
                p++;
                p1.Value = p;
            }
        }

        private void ot2_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (ot2.Text == "Кольцо")
            {
                p++;
                p1.Value = p;
            }
        }

        private void ot3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ot3.Text == "5")
            {
                p++;
                p1.Value = p;
            }
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
