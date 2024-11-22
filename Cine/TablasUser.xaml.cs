using Cine.Usuario;
using GUICine2Vista.Peliculas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Cine
{
    /// <summary>
    /// Lógica de interacción para TablasUser.xaml
    /// </summary>
    public partial class TablasUser : Window
    {
        private Role rolUser;
        private Role rolUsuario;

        // Propiedad para las películas
        public ObservableCollection<Pelicula> Peliculas { get; set; }

        public TablasUser(List<Pelicula> peliculas, Role rol)
        {
            InitializeComponent();
            Peliculas = new ObservableCollection<Pelicula>(peliculas);
            DataContext = this; // Asegurarse de que el DataContext esté correctamente configurado
            rolUser = rol;
            InitializeUI();
        }

        public TablasUser(ObservableCollection<Pelicula> peliculas, Role rolUsuario)
        {
            InitializeComponent();
            this.rolUsuario = rolUsuario;

            // Crear la lista de películas por defecto
            Peliculas = new ObservableCollection<Pelicula>
            {
                new Pelicula()
                {
                    Titulo = "La Aventura Espacial",
                    Idioma = "Español",
                    Genero = new List<string> { "Ciencia Ficción", "Aventura" },
                    Duracion = 120,
                    Sala = 1,
                    FechaInicio = new DateTime(2024, 10, 10),
                    FechaFin = new DateTime(2024, 10, 20)
                },
                new Pelicula()
                {
                    Titulo = "El Último Samurai",
                    Idioma = "Inglés",
                    Genero = new List<string> { "Acción", "Drama" },
                    Duracion = 150,
                    Sala = 2,
                    FechaInicio = new DateTime(2024, 10, 15),
                    FechaFin = new DateTime(2024, 10, 30)
                },
                new Pelicula()
                {
                    Titulo = "Cazadores de Sombras",
                    Idioma = "Español",
                    Genero = new List<string> { "Fantasía", "Aventura" },
                    Sala = 3,
                    Duracion = 130,
                    FechaInicio = new DateTime(2024, 10, 12),
                    FechaFin = new DateTime(2024, 10, 28)
                },
                new Pelicula()
                {
                    Titulo = "La Vida es Bella",
                    Idioma = "Italiano",
                    Genero = new List<string> { "Drama", "Comedia" },
                    Sala = 4,
                    Duracion = 116,
                    FechaInicio = new DateTime(2024, 10, 5),
                    FechaFin = new DateTime(2024, 10, 15)
                },
                new Pelicula()
                {
                    Titulo = "Inception",
                    Idioma = "Inglés",
                    Genero = new List<string> { "Ciencia Ficción", "Thriller" },
                    Sala = 5,
                    Duracion = 148,
                    FechaInicio = new DateTime(2024, 10, 20),
                    FechaFin = new DateTime(2024, 11, 5)
                }
            };

            DataContext = this; // Asegurarse de que el DataContext esté correctamente configurado
            InitializeUI();
        }

        private void InitializeUI()
        {
            if (rolUser != Role.Admin)
            {
                AddMovies.Visibility = Visibility.Collapsed;
            }
        }

        private void addMovieBtn(Object sender, RoutedEventArgs e)
        {
            FormularioCambio formulario = new FormularioCambio(Peliculas);
            formulario.ShowDialog();
        }

        private void logOutClick(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();
        }

        private void DataGrid_SelectionChanged(object sender, RoutedEventArgs e)
        {
            // Lógica para el evento de selección en el DataGrid si se necesita
        }

        private void selectMovieClick(object sender, MouseButtonEventArgs e)
        {
            if(MoviesDataGrid.SelectedItem is Pelicula selectedMovie && MoviesDataGrid.CurrentColumn != null)
            {
                pruebaVentana prueba2 = new pruebaVentana();
                prueba2.ShowDialog();
            }
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}
