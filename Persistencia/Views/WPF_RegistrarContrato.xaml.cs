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
    /// Interaction logic for WPF_RegistrarContrato.xaml
    /// </summary>
    public partial class WPF_RegistrarContrato : Window
    {
        public WPF_RegistrarContrato()
        {
            InitializeComponent();
        }

        private void Btn_aceptar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Contrato agregado!!");
        }

        private void Btn_atras_Click(object sender, RoutedEventArgs e)
        {
            WPF_MenuPrincipal window = new WPF_MenuPrincipal();
            window.Show();
            this.Close();
        }

        private void Btn_consultar_Click(object sender, RoutedEventArgs e)
        {
            WPF_ConsultarContratos cc = new WPF_ConsultarContratos();
            cc.Show();
            this.Close();

        }
    }
}
