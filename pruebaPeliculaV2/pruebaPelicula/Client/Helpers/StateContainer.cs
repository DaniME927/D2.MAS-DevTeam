using System;
using pruebaPelicula.Shared.Entity;

namespace pruebaPelicula.Client.Helpers
{
    public class StateContainer
    {
        public string TextTyped { get; set; } = String.Empty;
        public bool EnCartelera { get; set; }
        public string LimpiarFiltros = "LimpiarFiltrosNoVisible";
        
        public event Action OnTextTyped;
        public event Action OnCheckCartelera;
        public event Action OnLimpiarFiltros;

        public void SearchingTextTyped (string Search)
        {
            TextTyped = Search;
            OnTextTyped?.Invoke();    
        }
        
        public void PeliculasEnCartelera(bool Check)
        {
            EnCartelera = Check;
            OnCheckCartelera?.Invoke();
        }

        public void RestablecerFiltros()
        {
            if (LimpiarFiltros == "LimpiarFiltrosNoVisible")
            {
                LimpiarFiltros = "LimpiarFiltrosVisible";
            }else {
                LimpiarFiltros = "LimpiarFiltrosNoVisible";
            }
            OnLimpiarFiltros?.Invoke();
        }
    }
}