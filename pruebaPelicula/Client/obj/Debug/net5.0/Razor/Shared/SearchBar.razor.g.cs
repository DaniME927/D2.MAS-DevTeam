#pragma checksum "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Shared\SearchBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "937e2ad5e369db187bbe16bb52e96f14118c26e5"
// <auto-generated/>
#pragma warning disable 1591
namespace pruebaPelicula.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class SearchBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid div-form p-0");
            __builder.OpenElement(2, "form");
            __builder.AddAttribute(3, "class", "d-flex");
            __builder.AddAttribute(4, "style", "width: 100%;");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "search");
            __builder.AddAttribute(7, "class", "form-control me-2 input-nav-form mr-2 FontSize");
            __builder.AddAttribute(8, "autocomplete", "off");
            __builder.AddAttribute(9, "placeholder", "Introduzca el nombre de una película, actor o categoría.");
            __builder.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Shared\SearchBar.razor"
                     film_search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film_search = __value, film_search));
            __builder.SetUpdatesAttributeName("Value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "btn btn-outline-success FontSize");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                                 SearchFilm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Buscar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Shared\SearchBar.razor"
       

    private string film_search = string.Empty;

    private void SearchFilm()
    {
        if (NavigatorPages.Uri != "/movies/search")
        {
            NavigatorPages.NavigateTo("/movies/search");
        }
        Console.WriteLine(film_search);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigatorPages { get; set; }
    }
}
#pragma warning restore 1591
