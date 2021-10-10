using System;
using System.Linq;
using System.Collections.Generic;
using pruebaPelicula.Shared.Entity;

namespace pruebaPelicula.Client.Helpers
{
    public class StateContainer
    {
        public string TextTyped { get; set; } = String.Empty;
        public Movie Movie { get; set; } = new Movie();
        public List<Movie> ListaPeliculas { get; set; } = new List<Movie>();
        
        public event Action OnActionEvent;

        public void SearchingTextTyped (string Search)
        {
            TextTyped = Search;
            OnActionEvent?.Invoke();    
        }

        public void ShowingInformation(Movie movie)
        {
            Movie = movie;
            OnActionEvent?.Invoke();
        }
        
    }
}