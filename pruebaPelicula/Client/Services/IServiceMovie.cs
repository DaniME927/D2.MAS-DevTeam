using pruebaPelicula.Shared.Entity;
using System.Collections.Generic;

namespace pruebaPelicula.Client.Services
{
    public interface IServiceMovie
    {
        List<Movie> GetMovies();
    }
}