using pruebaPelicula.Shared.Entity;
using System.Collections.Generic;

namespace pruebaPelicula.Client.Services
{
    public interface IServiceCategory
    {
         List<Category> GetCategories();
    }
}