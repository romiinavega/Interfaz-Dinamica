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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Interfaz_Dinamica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BtnGuardar.Visibility = Visibility.Hidden;
            BtnCancelar.Visibility = Visibility.Hidden;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grdParametrosPersona.Children.Clear();
            switch (comboxTitulo.SelectedIndex)
            {
                case 0:
                    grdParametrosPersona.Children.Add(new ParametrosAlumno());
                    BtnGuardar.Visibility = Visibility.Visible;
                    BtnCancelar.Visibility = Visibility.Visible;
                    break;
                case 1:
                    grdParametrosPersona.Children.Add(new ParametrosMaestro());
                    BtnGuardar.Visibility = Visibility.Visible;
                    BtnCancelar.Visibility = Visibility.Visible;
                    break;
            }
            }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            grdParametrosPersona.Children.Clear();
            BtnGuardar.Visibility = Visibility.Hidden;
            BtnCancelar.Visibility = Visibility.Hidden;
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdParametrosPersona.Children.Clear();
            BtnGuardar.Visibility = Visibility.Hidden;
            BtnCancelar.Visibility = Visibility.Hidden;
        }
    }
}
