#pragma checksum "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/Pages/Actores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b12d901d292dfba8080bcefdf636b8f3e93ee85"
// <auto-generated/>
#pragma warning disable 1591
namespace appPeliculas.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using appPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/appPeliculas/Client/_Imports.razor"
using appPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actores")]
    public partial class Actores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Registro de actores</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<form><div class=""mb-3 col-4""><label for=""name"" class=""form-label"">Nombre</label>
    <input type=""text"" class=""form-control"" id=""name"" aria-describedby=""title""></div>
  <div class=""mb-3 col-4""><label for=""birthDate"" class=""form-label"">Fecha de nacimiento</label>
    <input type=""date"" class=""form-control"" id=""birthDate"" aria-describedby=""birthDate""></div>
  <div class=""mb-3 col-4""><label for=""bio"" class=""form-label"">Biografía</label>
    <textarea class=""form-control"" id=""bio"" style=""height:20vh""></textarea></div>
  <button type=""submit"" class=""btn btn-primary"">Registrar</button></form>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591