#pragma checksum "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\HomeActors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b253e987454cc47b700c3a51b96880b734da0d93"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyBaseMuestraII.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/home-actor")]
    public partial class HomeActors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "jumbotron");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row d-flex justify-content-center");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "type", "button");
            __builder.AddAttribute(8, "class", "btn btn-success mx-3");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\HomeActors.razor"
                                                                           () => navigationManager.NavigateTo("/actors/create")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Crear actor");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-primary mx-3");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\HomeActors.razor"
                                                                           () => navigationManager.NavigateTo("/actors/edit/7")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Editar actor");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn btn-info mx-3");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\HomeActors.razor"
                                                                        () => navigationManager.NavigateTo("/actor")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Listar actores");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "type", "button");
            __builder.AddAttribute(26, "class", "btn btn-danger mx-3");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\HomeActors.razor"
                                                                          () => Console.WriteLine("En espera de implementar esta función")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Eliminar actor");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
