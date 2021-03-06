// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProyBaseMuestraII.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using ProyBaseMuestraII.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using ProyBaseMuestraII.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using ProyBaseMuestraII.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using ProyBaseMuestraII.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using ProyBaseMuestraII.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\_Imports.razor"
using ProyBaseMuestraII.Client.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class FiltroMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Movies\FiltroMovies.razor"
       

    private List<Movie> Movies;
    string movie_name = "";
    string categorySelected = "";
    private bool futurosEstrenos = false;
    private bool enCartelera = false;
    private bool mejorCalificadas = false;
    private List<Category> Categories = new List<Category>();

    protected override void OnInitialized()
    {
        Movies = movie.GetMovies();
    }

    private void MovieNameKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            CargarNuevasPeliculas();
        }
    }

    private void CargarNuevasPeliculas()
    {   
        Movies = movie.GetMovies().Where(x=>x.Name.ToLower().Contains(movie_name.ToLower())).ToList();
        Console.WriteLine($"Nombre pel??cula: {movie_name}");
        Console.WriteLine($"Categor??a seleccionada: {categorySelected}");
        Console.WriteLine($"En cartelera: {futurosEstrenos}");
        Console.WriteLine($"Futuros estrenos: {enCartelera}");
        Console.WriteLine($"Mejor calificada: {mejorCalificadas}");
    }

    private void LimpiarCampos()
    {
        Movies = movie.GetMovies();
        movie_name = "";
        Console.WriteLine($"Reset nombre pel??cula: {movie_name}");
        categorySelected = "0";
        futurosEstrenos = false;
        enCartelera = false;
        mejorCalificadas = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
