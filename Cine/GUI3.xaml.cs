using GUICine2Vista.Peliculas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para GUI3.xaml
    /// </summary>
    public partial class GUI3 : Window
    {

        private ObservableCollection<Pelicula> Peliculas;
        public GUI3(System.Collections.ObjectModel.ObservableCollection<GUICine2Vista.Peliculas.Pelicula> peliculas)
        {
            InitializeComponent();
        }

        private void ButtonAbrirGUI4_Click(object sender, RoutedEventArgs e)
        {
           
        }


    }
}
