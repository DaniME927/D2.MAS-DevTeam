#pragma checksum "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Pages/PeliculasIII.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5c286b3152cf1e605b537c3aa19f9c27dd56a14"
// <auto-generated/>
#pragma warning disable 1591
namespace pruebaPelicula.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Pages.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculasIII")]
    public partial class PeliculasIII : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<pruebaPelicula.Client.Pages.Components.MovieCardComponent>(0);
            __builder.AddAttribute(1, "ListMovies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<pruebaPelicula.Shared.Entity.Movie>>(
#nullable restore
#line 5 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Pages/PeliculasIII.razor"
                                  Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Pages/PeliculasIII.razor"
       

    private List<Movie> Movies;
    
    protected override void OnInitialized()
    {
        Movies = movie.GetMovies();
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
    }
}
#pragma warning restore 1591
