#pragma checksum "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\CardMoviesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "683472af4c363047837dbf6d7a39850d8dfcbdc0"
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
    public partial class CardMoviesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "jumbotron");
            __builder.AddMarkupContent(2, "<h6>Películas</h6>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row mb-3");
#nullable restore
#line 5 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\CardMoviesComponent.razor"
             foreach (var movie in ListMovies)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-4");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card flex-md-row mb-4 box-shadow h-md-300");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body d-flex flex-column align-items-center");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 11 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\CardMoviesComponent.razor"
                                           movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "card-img-top");
            __builder.AddAttribute(18, "alt", "...");
            __builder.AddAttribute(19, "height", "350px");
            __builder.AddAttribute(20, "width", "200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "card-body");
            __builder.OpenElement(24, "h5");
            __builder.AddAttribute(25, "class", "card-title");
            __builder.AddContent(26, 
#nullable restore
#line 13 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\CardMoviesComponent.razor"
                                                            movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                    ");
            __builder.OpenElement(28, "p");
            __builder.AddAttribute(29, "class", "card-text");
            __builder.AddContent(30, 
#nullable restore
#line 14 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\CardMoviesComponent.razor"
                                                          movie.Sinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card-footer");
            __builder.OpenElement(34, "small");
            __builder.AddAttribute(35, "class", "text-muted");
            __builder.AddContent(36, 
#nullable restore
#line 17 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\CardMoviesComponent.razor"
                                                               movie.Premier

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\CardMoviesComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Components\CardMoviesComponent.razor"
       

    [Parameter] public List<Movie> ListMovies { get; set; }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591