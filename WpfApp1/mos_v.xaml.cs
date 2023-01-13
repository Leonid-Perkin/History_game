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
    /// Логика взаимодействия для mos_v.xaml
    /// </summary>
    public partial class mos_v : Window
    {
        public mos_v()
        {
            InitializeComponent();

        }
        int k = 0;
        private void P_ot1_Checked(object sender, RoutedEventArgs e)
        {
            k++;
            p_b.Value = k;
        }

        private void P_ot2_Checked(object sender, RoutedEventArgs e)
        {
            k++;
            p_b.Value = k;
        }
    }
}
