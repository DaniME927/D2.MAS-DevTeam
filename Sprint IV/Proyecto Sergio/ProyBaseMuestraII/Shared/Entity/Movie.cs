using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyBaseMuestraII.Shared.Entity
{
    public class Movie
    {
        /* Incluimos las siguientes validaciones al campo nombre pelicula
        1. Que el nombre no este vacio o contenga unicamente un espacio en blanco (IsNullOrWhiteSpace)
        2. Validamos la longitud de la cadena de texto, que NO supere los 60 caracteres */

        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }
        public bool EnCartelera { get; set; }
        public string Poster { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Trailer { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Sinopsis { get; set; }
        public int Score { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime? Premier { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public List<CategoryMovie> CategoriesMovie { get; set; } = new List<CategoryMovie>();

        public string ShortName
        { 
            get
            {
                if (string.IsNullOrWhiteSpace(Name))
                {
                    return null;
                }
                if (Name.Length > 60)
                {
                    return Name.Substring(0, 60) + "...";
                }else {
                    return Name;
                }
            }
        }
    }
}