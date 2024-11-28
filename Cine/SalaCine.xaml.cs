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

namespace Cine
{
    /// <summary>
    /// Lógica de interacción para SalaCine.xaml
    /// </summary>
    public partial class SalaCine : Window
    {
        public SalaCine(int salaSeleccionada)
        {
            InitializeComponent();
        }


        private void Reserve_Click(object sender, RoutedEventArgs e)
        {
            var botones = new[] { SalaBtn1, SalaBtn2, SalaBtn3, SalaBtn4, SalaBtn5, SalaBtn6, SalaBtn7, SalaBtn8, SalaBtn9 };
            foreach (var boton in botones)
            {

                // Verificar si el botón es naranja
                if (boton.Background == Brushes.Orange)
                {
                    // Cambiar el color a rojo
                    boton.Background = Brushes.Red;
                }
            }


        }
        private void CambiarColor()
        {

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (SalaBtn1.Background == Brushes.Green)
            {
                SalaBtn1.Background = Brushes.Orange;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (SalaBtn2.Background == Brushes.Green)
            {
                SalaBtn2.Background = Brushes.Orange;
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (SalaBtn3.Background == Brushes.Green)
            {
                SalaBtn3.Background = Brushes.Orange;
            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (SalaBtn4.Background == Brushes.Green)
            {
                SalaBtn4.Background = Brushes.Orange;
            }
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (SalaBtn5.Background == Brushes.Green)
            {
                SalaBtn5.Background = Brushes.Orange;
            }
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (SalaBtn6.Background == Brushes.Green)
            {
                SalaBtn6.Background = Brushes.Orange;
            }

        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (SalaBtn7.Background == Brushes.Green)
            {
                SalaBtn7.Background = Brushes.Orange;
            }

        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (SalaBtn8.Background == Brushes.Green)
            {
                SalaBtn8.Background = Brushes.Orange;
            }
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (SalaBtn9.Background == Brushes.Green)
            {
                SalaBtn9.Background = Brushes.Orange;
            }
        }
    }
}
