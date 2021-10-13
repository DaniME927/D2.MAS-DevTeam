using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace pruebaPelicula.Shared.Entity
{
    public class Category
    {
        public Category() 
        {

        }

        public Category(int id, string name) 
        {
            this.Id = id;
            this.Name = name;   
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Este campo debe tener un mínimo de {2} carácteres y un máximo de {1} carácteres.")]
        public string Name { get; set; }

        public List<MovieCategory> MoviesCategory { get; set; } = new List<MovieCategory>();
    }
}