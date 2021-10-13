using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace pruebaPelicula.Shared.Entity
{
    public class Movie
    {
        public Movie() 
        {

        }

        public Movie(int id, string name, int durationHour, int durationMinute, bool enCartelera, string poster, string trailer, string sinopsis, int score) 
        {
            this.Id = id;
            this.Name = name;
            this.DurationHour = durationHour;
            this.DurationMinute = durationMinute;
            this.EnCartelera = enCartelera;
            this.Poster = poster;
            this.Trailer = trailer;
            this.Sinopsis = sinopsis;
            this.Score = score;
        }
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "Este campo debe tener un mínimo de {2} carácteres y un máximo de {1} carácteres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [Range(0, 9, ErrorMessage = "El rango debe ser entre 0 y 9.")]
        public int? DurationHour { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [Range(0, 59, ErrorMessage = "El rango debe ser entre 0 y 59.")]
        public int? DurationMinute { get; set; }
        public bool EnCartelera { get; set; }
        public string Poster { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Trailer { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(500, MinimumLength = 150, ErrorMessage = "Este campo debe tener un mínimo de {2} carácteres y un máximo de {1} carácteres.")]
        public string Sinopsis { get; set; } = String.Empty;
        [Required(ErrorMessage = "Este campo es requerido.")]
        [Range(0, 10, ErrorMessage = "El rango debe ser entre 0 a 10.")]
        public int? Score { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        public DateTime? Premier { get; set; }

        public List<MovieCategory> MoviesCategory { get; set; } = new List<MovieCategory>();
        public List<MovieActor> MoviesActor { get; set; } = new List<MovieActor>();
    }
}