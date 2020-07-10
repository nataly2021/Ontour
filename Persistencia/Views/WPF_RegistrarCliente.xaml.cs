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
    /// Interaction logic for WPF_RegistrarCliente.xaml
    /// </summary>
    public partial class WPF_RegistrarCliente : Window
    {
        ServicioCliente sc = new ServicioCliente();
        public WPF_RegistrarCliente()
        {
            InitializeComponent();
        }

        private void RegistrarCliente()
        {
            try
            {
                string rut;
                string nombres;
                string apellidos;
                string mail;
                string telefono;


                if (txtrut.Text.Trim().Length > 0)
                {
                    rut = txtrut.Text;
                }
                else
                {
                    MessageBox.Show("Error:", "Debes ingresar un Rut válido");
                    return;
                }
                if (txtnombre.Text.Trim().Length > 0)
                {
                    nombres = txtnombre.Text;
                }
                else
                {
                    MessageBox.Show("Error:", "Debes ingresar un nombre válido");
                    return;
                }
                if (txtApellido.Text.Trim().Length > 0)
                {
                    apellidos = txtApellido.Text;
                }
                else
                {
                    MessageBox.Show("Error:", "Debes ingresar una Razon Social válida");
                    return;
                }
                if (txtmail.Text.Trim().Length > 0)
                {
                    mail = txtmail.Text;
                }
                else
                {
                    MessageBox.Show("Error:", "Debes ingresar un mail válido");
                    return;
                }

                if (txttelefono.Text.Trim().Length > 0)
                {
                    telefono = txttelefono.Text;
                }
                else
                {
                    MessageBox.Show("Error:", "Debes ingresar un numero de telefono válido");
                    return;
                }

                CLIENTE cliente = new CLIENTE
                {
                    Rut_Cliente = rut,
                    Nombre_Completo = nombres,
                    Apellido_Completo = apellidos,
                    Corre_Electronico = mail,


                };
                sc.AddEntity(cliente);
                MessageBox.Show("Exito:", "Datos del cliente registrados correctamente!!!");

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }

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
