using System;
using System.Collections.Generic;

namespace GUICine2Vista.Peliculas
{
    public class Pelicula
    {
        public string Titulo { get; set; }
        public string Idioma { get; set; }
        public List<string> Genero { get; set; }
        public int Duracion { get; set; }
        public int Sala { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Pelicula()
        {
        }

        public string showGenre
        {
            get
            {
                return string.Join(", ", Genero);
            }
        }
    }
}
