#pragma checksum "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\CrearPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8851af1c6ef1c0312f67fdb01023634793e4c658"
// <auto-generated/>
#pragma warning disable 1591
namespace pruebaPelicula.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Actors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/create")]
    public partial class CrearPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<pruebaPelicula.Client.Pages.Components.ComponentFormularioPelicula>(0);
            __builder.AddAttribute(1, "MovieModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<pruebaPelicula.Shared.Entity.Movie>(
#nullable restore
#line 4 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\CrearPelicula.razor"
                                         Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\CrearPelicula.razor"
                                                               CreateMovie

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "NoSelectedList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<pruebaPelicula.Shared.Entity.Category>>(
#nullable restore
#line 4 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\CrearPelicula.razor"
                                                                                            NoSelectedCategoryList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "SelectedList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<pruebaPelicula.Shared.Entity.Category>>(
#nullable restore
#line 4 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\CrearPelicula.razor"
                                                                                                                                  SelectedCategoryList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\CrearPelicula.razor"
       

    private Movie Movie = new Movie();
    private List<Category> NoSelectedCategoryList = new List<Category>();
    private List<Category> SelectedCategoryList = new List<Category>();

    protected override void OnInitialized()
    {
        NoSelectedCategoryList = categories.GetCategories();
    }

    private void CreateMovie()
    {
        Console.WriteLine($"Nombre de la pel??cula: {Movie.Name}");
        Console.WriteLine($"Trailer de la pel??cula: {Movie.Trailer}");
        Console.WriteLine($"En cartelera: {Movie.EnCartelera}");
        Console.WriteLine($"Puntuaci??n de la pel??cula: {Movie.Score}");
        Console.WriteLine($"Horas de la pel??cula: {Movie.DurationHour}");
        Console.WriteLine($"Minutos de la pel??cula: {Movie.DurationMinute}");
        Console.WriteLine($"Sinopsis de la pel??cula: {Movie.Sinopsis}");
        Console.WriteLine($"Fecha de estreno de la pel??cula: {Movie.Premier}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceCategory categories { get; set; }
    }
}
#pragma warning restore 1591
