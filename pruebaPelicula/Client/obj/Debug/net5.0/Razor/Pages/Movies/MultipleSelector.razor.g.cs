#pragma checksum "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "660d2a1c04cc3b3164b366d39ab7886bd2975f25"
// <auto-generated/>
#pragma warning disable 1591
namespace pruebaPelicula.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Actors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    public partial class MultipleSelector : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "ContainerMultipleSelector");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "b-pm8vo2aa6a");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "FieldList");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.AddAttribute(7, "b-pm8vo2aa6a");
#nullable restore
#line 3 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
         foreach (var item in NoSelectedSorted)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
                            () => Seleccionar(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "b-pm8vo2aa6a");
            __builder.AddContent(11, 
#nullable restore
#line 5 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
                                                       item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 6 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "id", "Buttons");
            __builder.AddAttribute(15, "class", "form-group my-auto mx-3");
            __builder.AddAttribute(16, "b-pm8vo2aa6a");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "id", "SeleccionarButton");
            __builder.AddAttribute(19, "class", "my-2");
            __builder.AddAttribute(20, "b-pm8vo2aa6a");
            __builder.OpenElement(21, "button");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "class", "btn btn-light");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
                                                                 SeleccionarTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "b-pm8vo2aa6a");
            __builder.AddContent(26, 
#nullable restore
#line 10 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
                                                                                   TextoSeleccionar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "id", "DeseleccionrButton");
            __builder.AddAttribute(30, "class", "my2");
            __builder.AddAttribute(31, "b-pm8vo2aa6a");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "class", "btn btn-light");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
                                                                  DeseleccionarTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "b-pm8vo2aa6a");
            __builder.AddContent(37, 
#nullable restore
#line 13 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
                                                                                      TextoDeseleccionar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "id", "FieldList");
            __builder.AddAttribute(41, "class", "form-group");
            __builder.AddAttribute(42, "b-pm8vo2aa6a");
#nullable restore
#line 17 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
         foreach (var item in SelectedSorted)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "li");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
                            () => Deseleccionar(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "b-pm8vo2aa6a");
            __builder.AddContent(46, 
#nullable restore
#line 19 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
                                                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\Movies\MultipleSelector.razor"
       

    [Parameter] public List<MultipleSelectorModel> NoSelected { get; set; } = new List<MultipleSelectorModel>();
    [Parameter] public List<MultipleSelectorModel> Selected { get; set; } = new List<MultipleSelectorModel>();
    private string TextoSeleccionar = ">>";
    private string TextoDeseleccionar = "<<";
    private List<MultipleSelectorModel> NoSelectedSorted = new List<MultipleSelectorModel>();
    private List<MultipleSelectorModel> SelectedSorted = new List<MultipleSelectorModel>();

    protected override void OnInitialized()
    {
        SortedList();
    }

    private void SortedList()
    {
        NoSelectedSorted = NoSelected.OrderBy(x => x.Name).ToList();
        SelectedSorted = Selected.OrderBy(x => x.Name).ToList();
    }

    private void Seleccionar(MultipleSelectorModel item)
    {
        NoSelected.Remove(item);
        Selected.Add(item);
        SortedList();
    }

    private void Deseleccionar(MultipleSelectorModel item)
    {
        Selected.Remove(item);
        NoSelected.Add(item);
        SortedList();
    }

    private void SeleccionarTodo()
    {
        Selected.AddRange(NoSelected);
        NoSelected.Clear();
        SortedList();
    }

    private void DeseleccionarTodo()
    {
        NoSelected.AddRange(Selected);
        Selected.Clear();
        SortedList();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
