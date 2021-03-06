#pragma checksum "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634a36c722c793ddfc5cb2e990fb83f47fd7d3cf"
// <auto-generated/>
#pragma warning disable 1591
namespace pruebaPelicula.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Actors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sandr\Desktop\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class ActorCardComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-deck d-flex justify-content-center mx-auto");
            __builder.AddAttribute(2, "id", "card-deck");
#nullable restore
#line 4 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
     if (ListActors.Any())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
         foreach (var actor in ListActors)
        {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card d-flex align-items-center my-3 p-1");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-img-info");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 11 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
                               actor.Photo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "class", "card-img-top");
            __builder.AddAttribute(10, "alt", 
#nullable restore
#line 11 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
                                                                       actor.ActorName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-info");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "style", "color: white;");
            __builder.AddContent(16, 
#nullable restore
#line 13 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
                                                  actor.Biography

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row mb-3 m-0 d-flex justify-content-end");
            __builder.AddAttribute(20, "id", "container-rate-description");
            __builder.AddMarkupContent(21, "<span class=\"mr-2\"><img src=\"Images/star.png\" id=\"icon-star-description\"></span>\r\n                            ");
            __builder.OpenElement(22, "em");
            __builder.OpenElement(23, "h4");
            __builder.AddAttribute(24, "class", "m-0 p-0");
            __builder.AddAttribute(25, "id", "rate-description");
            __builder.AddContent(26, "Nominaciones: ");
            __builder.AddContent(27, 
#nullable restore
#line 18 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
                                                                                         actor.Nominations

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "card-body");
            __builder.OpenElement(31, "h5");
            __builder.AddAttribute(32, "class", "card-title");
            __builder.AddContent(33, 
#nullable restore
#line 23 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
                                            actor.ActorName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.AddMarkupContent(35, "<div class=\"a-group\"><a class=\"btn btn-link\" id=\"btn-details\">Detalles</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
           
    }else {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "<p class=\"my-3 text-center\">No se encontraron coincidencias.</p>");
#nullable restore
#line 33 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n");
            __builder.AddMarkupContent(38, @"<div class=""d-flex justify-content-center""><nav aria-label=""pagination-nav""><ul class=""pagination""><li class=""page-item disabled""><span class=""page-link"">Previous</span></li>
            <li class=""page-item active""><span class=""page-link"">
                    1
                    <span class=""sr-only"">(current)</span></span></li>
            <li class=""page-item""><a class=""page-link"" href=""peliculas2"">2</a></li>
            <li class=""page-item""><a class=""page-link"" href=""peliculas2"">3</a></li>
            <li class=""page-item""><a class=""page-link"" href=""peliculas2"">Next</a></li></ul></nav></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ActorCardComponent.razor"
       

    [Parameter] public List<Actor> ListActors { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
