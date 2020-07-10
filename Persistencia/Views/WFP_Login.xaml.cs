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
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;

namespace Views
{
    /// <summary>
    /// Lógica de interacción para WFP_IniciarSesion.xaml
    /// </summary>
    public partial class WFP_Login : Window

    {
        string usuario = "admin";
        string password = "123";

        public WFP_Login()
        {
            InitializeComponent();
        }

        private  void ValidarIngreso()
        {
            if (Txtusuario.Text.Equals(usuario) && txtpassword.Password.Equals(password))
            {
                WPF_MenuPrincipal window = new WPF_MenuPrincipal();
                window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error", "Nombre usuario y/o contraseña inválidos");
            }
        }


        private void OnClick(object sender, RoutedEventArgs e)
        {
            ValidarIngreso();
            
        }
    }
}
