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
    }
}
