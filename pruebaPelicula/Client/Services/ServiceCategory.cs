using pruebaPelicula.Shared.Entity;
using System.Collections.Generic;

namespace pruebaPelicula.Client.Services
{
    public class ServiceCategory : IServiceCategory
    {
        public List<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category( 1, "Comedia" ),
                new Category( 2, "Acción" ),
                new Category( 3, "Romance" ),
                new Category( 4, "Terror" ),
                new Category( 5, "Drama" ),
                new Category( 6, "Ciencia ficción" ),
                new Category( 7, "Musical" ),
                new Category( 8, "Anime" ),
                new Category( 9, "Animación" )
            };
        }      
    }
}