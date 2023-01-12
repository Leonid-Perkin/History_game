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
    /// Логика взаимодействия для Event_Selection.xaml
    /// </summary>
    public partial class Event_Selection : Window
    {
        public Event_Selection()
        {
            InitializeComponent();
        }

        private void st_b_Click(object sender, RoutedEventArgs e)
        {
            st_window win2 = new st_window();
            win2.Show();
            Close();
        }

        private void kr_b_Click(object sender, RoutedEventArgs e)
        {
            kr_window win2 = new kr_window();
            win2.Show();
            Close();
        }

        private void ms_b_Click(object sender, RoutedEventArgs e)
        {
            mos_b_window win2 = new mos_b_window();
            win2.Show();
            Close();
        }

        private void ob_f_Click(object sender, RoutedEventArgs e)
        {
            ob_window win2 = new ob_window();
            win2.Show();
            Close();
        }
    }
}
