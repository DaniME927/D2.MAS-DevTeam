#pragma checksum "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ModalInformacionPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08fc7d1e42cbfa0d61234e9c2f6151c2e5cd37a"
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
    public partial class ModalInformacionPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"my-auto mx-auto\" id=\"container-informacionpelicula\"><div class=\"row mt-4 mx-0\"><div class=\"col-md-3 d-flex\" id=\"container-rate\"><span class=\"mr-2\"><img src=\"Images/star.png\" id=\"icon-star\"></span>\r\n            <em><h4 class=\"m-0 p-0\" id=\"rate\">10 /10</h4></em></div></div>\r\n\r\n    <div class=\"row my-4\"><div class=\"col-md-3 d-flex\" id=\"campos-txt\"><h5 id=\"h5-info\">Nombre:</h5></div>\r\n        <div class=\"col-md-9 d-flex\"><h6 class=\"m-0 text-muted\" id=\"h6-info\">Shang-Chi y la leyenda de los diez anillos</h6></div></div>\r\n\r\n    <div class=\"row my-4\"><div class=\"col-md-3 d-flex\" id=\"campos-txt\"><h5 id=\"h5-info\">Sinopsis:</h5></div>\r\n        <div class=\"col-md-9 d-flex\"><h6 class=\"m-0 text-muted\" id=\"h6-info\">Lorem ipsum dolor sit amet consectetur adipisicing elit. Quasi cupiditate maxime, ut, \r\n            aliquid mollitia ab pariatur, ea minima iusto assumenda sequi architecto. Animi iure iusto dolorum ipsam repellat expedita. Qui!</h6></div></div>\r\n\r\n    <div class=\"row my-4 my-3\"><div class=\"col-md-3 d-flex\" id=\"campos-txt\"><h5 id=\"h5-info\">Idioma:</h5></div>\r\n        <div class=\"col-md-9 d-flex\"><h6 class=\"m-0 text-muted\" id=\"h6-info\">Espa??ol, Ingl??s</h6></div></div>\r\n\r\n    <div class=\"row my-4 my-3\"><div class=\"col-md-3 d-flex\" id=\"campos-txt\"><h5 id=\"h5-info\">Duraci??n:</h5></div>\r\n        <div class=\"col-md-9 d-flex\"><h6 class=\"m-0 text-muted\" id=\"h6-info\">1h 30m</h6></div></div>\r\n\r\n    <div class=\"row my-4 my-3\"><div class=\"col-md-3 d-flex\" id=\"campos-txt\"><h5 id=\"h5-info\">Reparto:</h5></div>\r\n        <div class=\"col-md-9 d-flex\"><h6 class=\"m-0 text-muted\" id=\"h6-info\">Robert Downey Jr, Chris Hemsworth, Mark Ruffalo, Scarlett Johansson, Jeremy\r\n                Renner</h6></div></div>\r\n\r\n    <div class=\"row my-4 my-3\"><div class=\"col-md-3 d-flex\" id=\"campos-txt\"><h5 id=\"h5-info\">Categor??a:</h5></div>\r\n        <div class=\"col-md-9 d-flex\"><h6 class=\"m-0 text-muted\" id=\"h6-info\">Acci??n</h6></div></div>\r\n\r\n    <div class=\"row mt-4 style=\" background-color: green;\"><div class=\"col-md-3 d-flex\" id=\"campos-txt\"><h5 id=\"h5-info\">Fecha de estreno:</h5></div>\r\n        <div class=\"col-md-9 d-flex\"><small class=\"text-muted\"><cite>21/09/2021</cite></small></div></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
