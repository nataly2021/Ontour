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
    /// Interaction logic for WPF_AgregarSeguro.xaml
    /// </summary>
    public partial class WPF_AgregarSeguro : Window
    {
        ServicioSeguro Se = new ServicioSeguro();

        public WPF_AgregarSeguro()
        {
            InitializeComponent();
        }

        private  void RegistrarAutor()
        {
            try
            {
                //int id = int.Parse(txtid_seguro.Text);
                string nombre = txtSeguroName.Text;
                int monto = int.Parse(txtSeguroMonto.Text);
                SEGURO seguro = new SEGURO
                {
                    //ID = id
                    Nombre_Seguro = nombre,
                    Monto_Seguro = monto
                };
                Se.AddEntity(seguro);
                MessageBox.Show("Exito:", "Datos del Seguro registrados correctamente!!!");
              
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error:", ex.Message);
            }
        }




       private void Btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            RegistrarAutor();
        }

        private void Btn_atras_Click(object sender, RoutedEventArgs e)
        {
            WPF_MenuPrincipal window = new WPF_MenuPrincipal();
            window.Show();
            this.Close();
        }

       
    }
}
