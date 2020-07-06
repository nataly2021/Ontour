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
    /// Interaction logic for WPF_MenuPrincipal.xaml
    /// </summary>
    public partial class WPF_MenuPrincipal : Window
    {
        public WPF_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Btn_reg_cliente_Click(object sender, RoutedEventArgs e)
        {
            WPF_RegistrarCliente window = new WPF_RegistrarCliente();
            window.Show();
            this.Close();
        }

        private void Btn_reg_contrato_Click(object sender, RoutedEventArgs e)
        {
            WPF_RegistrarContrato window = new WPF_RegistrarContrato();
            window.Show();
            this.Close();
        }

        private void Btn_consultar_monto_Click(object sender, RoutedEventArgs e)
        {
            WPF_ConsultarMonto window = new WPF_ConsultarMonto();
            window.Show();
            this.Close();
        }

        private void Btn_agr_seg_Click(object sender, RoutedEventArgs e)
        {
            WPF_AgregarSeguro window = new WPF_AgregarSeguro();
            window.Show();
            this.Close();
        }

       

        private void Btn_cerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
