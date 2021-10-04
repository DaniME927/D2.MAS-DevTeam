using System.Collections.Generic;
using ProyBaseMuestraII.Shared.Entity;

namespace ProyBaseMuestraII.Client.Services
{
    public interface IServiceCategory
    {
         List<Category> GetCategories();
    }
}