using System;
using System.Linq;
using System.Collections.Generic;
using pruebaPelicula.Shared.Entity;

namespace pruebaPelicula.Client.Helpers
{
    public class StateContainer
    {
        public string TextTyped { get; set; } = String.Empty;
        public List<Movie> ListaPeliculas { get; set; } = new List<Movie>();
        
        public event Action OnTextTyped;

        public void SearchingTextTyped (string Search)
        {
            TextTyped = Search;
            OnTextTyped?.Invoke();    
        }
        
    }
}