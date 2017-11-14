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

namespace WPFDEMO
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nimi = txtNimi.Text;
            txbMessu.Text = "Terve " + nimi;
        }

        private void txtNimi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbVarit_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //selvitetään mikä väri valittu
            string vari = cmbVarit.SelectedValue.ToString();
            txbMessu.Text = vari;

        }
    }
}
