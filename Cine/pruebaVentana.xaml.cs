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
    /// Lógica de interacción para pruebaVentana.xaml
    /// </summary>
    public partial class pruebaVentana : Window
    {
        public pruebaVentana()
        {
            InitializeComponent();
        }

        private void closeWinBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
