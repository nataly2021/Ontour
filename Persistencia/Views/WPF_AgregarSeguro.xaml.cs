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

namespace Views
{
    /// <summary>
    /// Interaction logic for WPF_AgregarSeguro.xaml
    /// </summary>
    public partial class WPF_AgregarSeguro : Window
    {
        public WPF_AgregarSeguro()
        {
            InitializeComponent();
        }

        private void Btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Seguro Agregado!!!");
        }

        private void Btn_atras_Click(object sender, RoutedEventArgs e)
        {
            WPF_MenuPrincipal window = new WPF_MenuPrincipal();
            window.Show();
            this.Close();
        }
    }
}
