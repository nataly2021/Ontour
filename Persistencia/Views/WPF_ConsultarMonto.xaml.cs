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
using Persistencia;
using Servicios;

namespace Views
{
    /// <summary>
    /// Interaction logic for WPF_ConsultarMonto.xaml
    /// </summary>
    public partial class WPF_ConsultarMonto : Window
    {
        ServicioAbonos Sa = new ServicioAbonos();

        public WPF_ConsultarMonto()
        {
            InitializeComponent();
        }

        private  void CargarListadoAbonos()
        {
            try
            {
                List<ABONOS> abonos = Sa.GetEntities();
                cmbNROAbono.ItemsSource = abonos;
                cmbNROAbono.SelectedValuePath = "NRO Abono";
                cmbNROAbono.DisplayMemberPath = "Monto";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }

        }




        //private  void BuscarDatosAbonos()
        //{
        //    try
        //    {
        //       ABONOS abonos = Sa.GetEntity(txtNROAbono.Text);
        //        if (abonos != null)
        //        {
        //            MessageBox.Show("Exito:", "Abono encontrado con exito");
        //            cmbNROAbono.Text= abonos.Monto;

        //        }
        //        else
        //        {
        //            MessageBox.Show("Error:", "Debe ingresar un rut valido");
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show ("Error:", "No se ha podido encontrar al cliente." + ex.Message);
        //    }

        //}




        private void Btn_consultar_Click(object sender, RoutedEventArgs e)
        {
            
           // BuscarDatosAbonos();
        }

        private void Btn_atras_Click(object sender, RoutedEventArgs e)
        {
            WPF_MenuPrincipal window = new WPF_MenuPrincipal();
            window.Show();
            this.Close();
        }
    }
}
