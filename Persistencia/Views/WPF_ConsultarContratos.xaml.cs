﻿using System;
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
    /// Interaction logic for WPF_ConsultarContratos.xaml
    /// </summary>
    public partial class WPF_ConsultarContratos : Window
    {
        public WPF_ConsultarContratos()
        {
            InitializeComponent();
        }

        private void Btn_atras_Click(object sender, RoutedEventArgs e)
        {
            WPF_RegistrarContrato rc = new WPF_RegistrarContrato();
            rc.Show();
            this.Close();
        }


    }
}
