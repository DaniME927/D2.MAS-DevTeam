#pragma checksum "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Movies\EditMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68229433fcf2a40afd4ceb314638e4606cca7f38"
// <auto-generated/>
#pragma warning disable 1591
namespace ProyBaseMuestraII.Client.Pages.Movies
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/edit/{MovieId:int}")]
    public partial class EditMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<ProyBaseMuestraII.Client.Pages.Components.FormMovie>(0);
            __builder.AddAttribute(1, "MovieModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ProyBaseMuestraII.Shared.Entity.Movie>(
#nullable restore
#line 4 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Movies\EditMovie.razor"
                       Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 4 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Movies\EditMovie.razor"
                                             Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\sandr\Desktop\Proyectos v.2\ProyBaseMuestraII\Client\Pages\Movies\EditMovie.razor"
                                                                                    
    [Parameter] public int MovieId { get; set; }
    Movie Movie = new Movie();

    protected override void OnInitialized()
    {
        Movie = new Movie() { Id = MovieId, Name = "Spiderman" };
    }

    private void Edit()
    {
        Console.WriteLine($"Id pel??cula {Movie.Id}");
        Console.WriteLine($"Actualizar nombre pel??cula {Movie.Name}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
