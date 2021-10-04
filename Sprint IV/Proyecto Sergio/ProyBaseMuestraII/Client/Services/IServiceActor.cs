using System.Collections.Generic;
using ProyBaseMuestraII.Shared.Entity;

namespace ProyBaseMuestraII.Client.Services
{
    public interface IServiceActor
    {
         List<Actor> GetActors();
    }
}