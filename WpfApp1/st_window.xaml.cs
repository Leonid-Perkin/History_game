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
    /// Логика взаимодействия для st_window.xaml
    /// </summary>
    public partial class st_window : Window
    {
        public st_window()
        {
            InitializeComponent();
        }
        private void b1_Click(object sender, RoutedEventArgs e)
        {
            st_b_v win2 = new st_b_v();
            win2.Show();
            Close();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            st_b_k win2 = new st_b_k();
            win2.Show();
            Close();
        }
    }
}
