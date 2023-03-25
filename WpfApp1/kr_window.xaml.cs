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
    /// Логика взаимодействия для kr_window.xaml
    /// </summary>
    public partial class kr_window : Window
    {
        public kr_window()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            kr_b_v win2 = new kr_b_v();
            win2.Show();
            Close();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            kr_b_k win2 = new kr_b_k();
            win2.Show();
            Close();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Event_Selection win2 = new Event_Selection();
            win2.Show();
            Close();
        }
    }
}
