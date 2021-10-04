#pragma checksum "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\MovieComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a0ff395fd43d1ee794f760602611dfbe8784f9"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyBaseMuestraII.Client.Pages.Components
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
    public partial class MovieComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "style", "margin-right: 2%; margin-bottom: 10px; text-align: center;");
            __builder.OpenElement(2, "a");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 3 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\MovieComponent.razor"
                   Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(5, "alt");
            __builder.AddAttribute(6, "width", "225px");
            __builder.AddAttribute(7, "height", "300px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "style", "max-width: 225px; height: 44px; font-size: 15px; font-weight: bold;");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", 
#nullable restore
#line 6 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\MovieComponent.razor"
                  urlMovie

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(13, 
#nullable restore
#line 6 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\MovieComponent.razor"
                             Movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "<a class=\"btn btn-info\">Editar</a>\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "btn btn-danger");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\MovieComponent.razor"
                                                                   ()=>DeleteMovie.InvokeAsync(Movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\MovieComponent.razor"
       

    [Parameter] public Movie Movie { get; set; }
    [Parameter] public EventCallback<Movie> DeleteMovie { get; set; }
    private string urlMovie = string.Empty;
    
    protected override void OnInitialized()
    {
        urlMovie = $"movie/";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591