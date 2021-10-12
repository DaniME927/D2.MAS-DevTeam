using System;
using System.Linq;
using System.Collections.Generic;
using pruebaPelicula.Shared.Entity;

namespace pruebaPelicula.Client.Helpers
{
    public class StateContainer
    {
        public string TextTyped { get; set; } = String.Empty;
        public bool EnCartelera { get; set; }
        
        
        
        public event Action OnTextTyped;

        public void SearchingTextTyped (string Search)
        {
            TextTyped = Search;
            OnTextTyped?.Invoke();    
        }
        
        public void PeliculasEnCartelera(bool Check)
        {
            EnCartelera = Check;
            OnTextTyped?.Invoke();
        }
    }
}