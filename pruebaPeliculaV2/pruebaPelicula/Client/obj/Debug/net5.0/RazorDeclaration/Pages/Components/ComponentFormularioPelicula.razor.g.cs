// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class ComponentFormularioPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 122 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ComponentFormularioPelicula.razor"
       

    [Parameter] public Movie MovieModel { get; set; }
    [Parameter] public EventCallback OnValidSubmit {get; set; }
    [Parameter] public List<Category> NoSelectedList { get; set; }
    [Parameter] public List<Category> SelectedList { get; set; }
    [Parameter] public List<Actor> ActoresSeleccionados { get; set; } = new List<Actor>();
    private List<MultipleSelectorModel> NoSelectedListModel = new List<MultipleSelectorModel>();
    private List<MultipleSelectorModel> SelectedListModel = new List<MultipleSelectorModel>();
    private List<Actor> ListaActores = new List<Actor>();
    private List<Actor> FiltroActores = new List<Actor>();
    private string posterTemporal;

    protected override void OnInitialized()
    {
        NoSelectedListModel = NoSelectedList.Select(x => new MultipleSelectorModel(x.Id.ToString(),x.Name)).ToList();
        SelectedListModel = SelectedList.Select(x => new MultipleSelectorModel(x.Id.ToString(),x.Name)).ToList();

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Pages\Components\ComponentFormularioPelicula.razor"
                                                                                 
        if (!string.IsNullOrWhiteSpace(MovieModel.Poster))
        {
            posterTemporal = MovieModel.Poster;
            MovieModel.Poster = null;
        }

        ListaActores = new List<Actor>(){
            new Actor(){Id=1, ActorName="Yaneth Mej??a", Photo="https://pbs.twimg.com/profile_images/1079060744891785216/dAsFSbHH_400x400.jpg"},
            new Actor(){Id=2, ActorName="Carolina Marquez", Photo="https://archivo.autonoma.edu.co/sites/default/files/styles/medium/public/carolina-marquez-narvaez.jpg?itok=CcL43PAR"},
            new Actor(){Id=3, ActorName="Juan Esteban", Photo="https://cdn1.vectorstock.com/i/1000x1000/29/65/cinema-award-best-actor-flat-style-vector-13602965.jpg"},
        };
    }

    private void ImageSelected(string image864)
    {
        MovieModel.Poster = image864;
    }

    public void LlamarJavascript()
    {
        jsRuntime.InvokeVoidAsync("EstructuraHTML");
    }

        private void LlamarJavascriptModal()
    {
        jsRuntime.InvokeVoidAsync("ModalAction");
    }

    private async Task<IEnumerable<Actor>> BuscarActores(string searchText)
    {
        await Task.Delay(0);
        return FiltroActores = ListaActores.Where(x => x.ActorName.Contains(searchText)).ToList();   
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
