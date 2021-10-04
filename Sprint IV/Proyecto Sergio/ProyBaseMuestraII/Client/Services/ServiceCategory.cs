using System;
using System.Collections.Generic;
using ProyBaseMuestraII.Shared.Entity;

namespace ProyBaseMuestraII.Client.Services
{
    public class ServiceCategory : IServiceCategory
    {
        public List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category() { Id = 1, Name = "Acción" },
                new Category() { Id = 2, Name = "Drama" },
                new Category() { Id = 3, Name = "Suspenso" },
                new Category() { Id = 4, Name = "Terror" },
                new Category() { Id = 5, Name = "Romance" },
                new Category() { Id = 6, Name = "Ciencia ficción" },
                new Category() { Id = 7, Name = "Comedia" }
            };
        }
    }
}