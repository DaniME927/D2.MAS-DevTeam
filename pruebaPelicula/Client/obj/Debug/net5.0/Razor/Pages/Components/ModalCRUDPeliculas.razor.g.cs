#pragma checksum "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Components\ModalCRUDPeliculas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6b6aaacf6b7e6961d1e9b333fa9781e213d4021"
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
    public partial class ModalCRUDPeliculas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""jumbotron"" style=""width: 50vw;""><div class=""form-group d-flex justify-content-center""><a role=""button"" href=""/movies/create"" class=""btn btn-success my-2 mx-2"">Crear Película</a>
        <a role=""button"" href=""/movies/edit/7"" class=""btn btn-primary my-2 mx-2"">Editar Película</a>
        <a role=""button"" href=""/"" class=""btn btn-danger my-2 mx-2"">Eliminar Película</a></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
