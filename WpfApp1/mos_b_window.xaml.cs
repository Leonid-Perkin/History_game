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
    /// Логика взаимодействия для mos_b_window.xaml
    /// </summary>
    public partial class mos_b_window : Window
    {
        public mos_b_window()
        {
            InitializeComponent();
        }

        private void vi_btn_Click(object sender, RoutedEventArgs e)
        {
            mos_v win2 = new mos_v();
            win2.Show();
            Close();
        }

        private void k_btn2_Click(object sender, RoutedEventArgs e)
        {
            Event_Selection win2 = new Event_Selection();
            win2.Show();
            Close();
        }
    }
}
