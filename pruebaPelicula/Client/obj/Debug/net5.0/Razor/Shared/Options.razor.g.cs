#pragma checksum "/Users/danielsanchez/Downloads/pruebaPelicula/Client/Shared/Options.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c03bd1050feac1fa4af45883aa05e4d9bb943e8"
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
#line 1 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/Shared/Options.razor"
using pruebaPelicula.Client.Components;

#line default
#line hidden
#nullable disable
    public partial class Options : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "nav options");
            __builder.AddAttribute(2, "b-8u2skf0bad");
            __builder.OpenElement(3, "a");
            __builder.AddAttribute(4, "class", "nav-link");
            __builder.AddAttribute(5, "href", "#");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/Shared/Options.razor"
                                            ()=>modal.Show<FormularioPelicula>("Registro de película")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-8u2skf0bad");
            __builder.AddMarkupContent(8, "Insertar Película");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "class", "nav-link");
            __builder.AddAttribute(12, "href", "#");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Users/danielsanchez/Downloads/pruebaPelicula/Client/Shared/Options.razor"
                                            ()=>modal.Show<FormularioActores>("Registro de actor")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "b-8u2skf0bad");
            __builder.AddContent(15, "Insertar Actor");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.AddMarkupContent(17, "<a class=\"nav-link\" href=\"#\" b-8u2skf0bad>Insertar Categoría</a>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
    }
}
#pragma warning restore 1591