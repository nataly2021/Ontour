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
    /// Interaction logic for WPF_RegistrarCliente.xaml
    /// </summary>
    public partial class WPF_RegistrarCliente : Window
    {
        public WPF_RegistrarCliente()
        {
            InitializeComponent();
        }

        private void Btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cliente Agregado!!");
            
        }

        private void Btn_atras_Cick(object sender, RoutedEventArgs e)
        {
            WPF_MenuPrincipal window = new WPF_MenuPrincipal();
            window.Show();
            this.Close();
        }
    }
}
