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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string shoppinglist = null;
                if ((bool)chb_1.IsChecked)
                {
                    shoppinglist += "Milk ";
                }
                if ((bool)chb_2.IsChecked)
                {
                    shoppinglist += "Butter ";
                }
                if ((bool)chb_3.IsChecked)
                {
                    shoppinglist += "Beer ";
                }
                if ((bool)chb_4.IsChecked)
                {
                    shoppinglist += "Chicken ";
                }
                if ((bool)chb_5.IsChecked)
                {
                    shoppinglist += "Lemonade ";
                }
                txbShoppinglist.Text = shoppinglist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}