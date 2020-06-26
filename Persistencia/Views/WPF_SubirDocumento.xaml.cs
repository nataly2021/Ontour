using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
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
    /// Interaction logic for WPF_SubirDocumento.xaml
    /// </summary>
    public partial class WPF_SubirDocumento : Window
    {
        public WPF_SubirDocumento()
        {
            InitializeComponent();
        }

        private void Btn_subir_doc_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog of = new Microsoft.Win32.OpenFileDialog();
            of.DefaultExt = ".txt";
            of.Multiselect = true;
            of.Filter = "Archivo txt (*.txt*)|*.txt*";
            
            if (of.ShowDialog()==true)
            {
                string archivo = of.FileName;
                doc.Text = archivo;
                txt.Text = System.IO.File.ReadAllText(archivo);
            }
            

        }

        private void Btn_atras_Click(object sender, RoutedEventArgs e)
        {
            WPF_MenuPrincipal window = new WPF_MenuPrincipal();
            window.Show();
            this.Close();
        }

        private void Btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Documento agregado correctamente!");
        }
    }
}
