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
using Servicios;
using Persistencia;

namespace Views
{
    /// <summary>
    /// Interaction logic for WPF_RegistrarContrato.xaml
    /// </summary>
    public partial class WPF_RegistrarContrato : Window
    {
        ServicioContrato sco = new ServicioContrato();

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
        private void RegistrarContrato()
        {
            try
            {
                string rutcontrato;
                string modalidad;
                string observaciones;
                string fechadeCreacion;



                if (txtNro.Text.Trim().Length > 0)
                {
                    rutcontrato = txtNro.Text;
                }
                else
                {
                    MessageBox.Show("Error:", "Debes ingresar un numero contrato válido");
                    return;
                }
                if (DTfechacreacion.Text.Trim().Length>0)
                {
                    fechadeCreacion = DTfechacreacion.SelectedDate.ToString();
                }
                else
                {
                    MessageBox.Show("Error:", "Debes ingresar una fecha válida");
                    return;
                }
                
                if (txtModalidad.Text.Trim().Length > 0)
                {
                    modalidad = txtModalidad.Text;
                }
                else
                {
                    MessageBox.Show("Error:", "Debes ingresar modalidad de servicio");
                    return;
                }

                if (txtObservaciones.Text.Trim().Length > 0)
                {
                    observaciones = txtObservaciones.Text;
                }
                else
                {
                    MessageBox.Show("Error:", "Debes ingresar Observaciones de Contrato");
                    return;
                }
                CONTRATO c = new CONTRATO();
                c.NRO_Contrato = Decimal.Parse(txtNro.Text);
                c.Creacion = DTfechacreacion.SelectedDate ?? default(DateTime);
                c.Termino = DTfechatermino.SelectedDate ?? default(DateTime);
                c.Modalidad = txtModalidad.Text;
                c.Observaciones = txtObservaciones.Text;

               
                sco.AddEntity(c);
                MessageBox.Show("Exito:", "Contrato agregado correctamente!!!");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }

        }

        //private void TerminoCoantrato()
        //{
        //    CONTRATO c = new CONTRATO();

        //    DTfechatermino = DateTime.Now();
        //}

    }
}
