#pragma checksum "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "971aa43d40ec42a73df7ad20ce31a68be101d024"
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
    public partial class SearchBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "SearchbarContainer");
            __builder.OpenElement(2, "input");
            __builder.AddAttribute(3, "type", "text");
            __builder.AddAttribute(4, "id", "InputTextSearch");
            __builder.AddAttribute(5, "class", "input-nav-form FontSize m-0 p-0");
            __builder.AddAttribute(6, "autocomplete", "off");
            __builder.AddAttribute(7, "placeholder", "Buscar...");
            __builder.AddAttribute(8, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                                           (KeyboardEventArgs e) => EnviarConsulta(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onfocusin", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                                                      () => TextSearch = string.Empty

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                              TextSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TextSearch = __value, TextSearch));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "id", "SearchIcon");
            __builder.AddAttribute(15, "class", "fas fa-search");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                         () => SearchingByFilter()

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "mt-4");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "id", "PeliculaRadio-Checkbox");
            __builder.AddAttribute(22, "class", "my-2");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-check");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "radio");
            __builder.AddAttribute(27, "id", "exampleRadios1");
            __builder.AddAttribute(28, "class", "form-check-input");
            __builder.AddAttribute(29, "name", "filtro");
            __builder.AddAttribute(30, "checked", 
#nullable restore
#line 14 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                                                      SelectedFilter == "pelicula"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                         () => SelectedFilter = "pelicula"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.AddMarkupContent(33, "<label for=\"exampleRadios1\" class=\"form-check-label LabelCheckboxSearch\">Pel??cula</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-check" + " " + (
#nullable restore
#line 18 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                                 @SelectedFilter == "pelicula" ? @EnCarteleraShow = "EnCartelera" : @EnCarteleraShow = "EnCarteleraHiden"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                               () => stateContainer.PeliculasEnCartelera(CheckEnCartelera)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "type", "checkbox");
            __builder.AddAttribute(40, "id", "EnCarteleraCheckbox");
            __builder.AddAttribute(41, "class", "form-check-input");
            __builder.AddAttribute(42, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                          CheckEnCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CheckEnCartelera = __value, CheckEnCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddMarkupContent(45, "<label for=\"EnCarteleraCheckbox\" class=\"form-check-label LabelCheckboxSearch\">En cartelera</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "form-check my-2");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "radio");
            __builder.AddAttribute(51, "id", "exampleRadios2");
            __builder.AddAttribute(52, "class", "form-check-input");
            __builder.AddAttribute(53, "name", "filtro");
            __builder.AddAttribute(54, "checked", 
#nullable restore
#line 25 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                                                  SelectedFilter == "actor"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                     () => { SelectedFilter = "actor"; CheckEnCartelera = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.AddMarkupContent(57, "<label for=\"exampleRadios2\" class=\"form-check-label LabelCheckboxSearch\">Actor</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n    ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-check my-2");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "radio");
            __builder.AddAttribute(63, "id", "exampleRadios3");
            __builder.AddAttribute(64, "class", "form-check-input");
            __builder.AddAttribute(65, "name", "filtro");
            __builder.AddAttribute(66, "checked", 
#nullable restore
#line 30 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                                                  SelectedFilter == "categoria"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
                     () => { SelectedFilter = "categoria"; CheckEnCartelera = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.AddMarkupContent(69, "<label for=\"exampleRadios3\" class=\"form-check-label LabelCheckboxSearch\">Categor??a</label>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\sandr\Desktop\pruebaPelicula\Client\Shared\SearchBar.razor"
       

    private string TextSearch = string.Empty;
    private string SelectedFilter = "pelicula";
    private string EnCarteleraShow = string.Empty;
    private bool CheckEnCartelera = false;
    
    private void SearchingByFilter()
    {
        if (!String.IsNullOrWhiteSpace(TextSearch))
        {
            stateContainer.SearchingTextTyped(TextSearch);
            stateContainer.LimpiarFiltros = "LimpiarFiltrosVisible";
        }else {
            stateContainer.LimpiarFiltros = "LimpiarFiltrosNoVisible";
        }
        if (navigationManager.Uri != "/movies" && SelectedFilter == "pelicula")
        {
            navigationManager.NavigateTo("/movies");
        }else {
            if (navigationManager.Uri != "/actors" && SelectedFilter == "actor")
            {
                navigationManager.NavigateTo("/actors");
            }else {
                if (navigationManager.Uri != "/categories" && SelectedFilter == "categoria")
                {
                    navigationManager.NavigateTo("/categories");
                }
            }
        }

        Console.WriteLine(TextSearch);
        Console.WriteLine(SelectedFilter);
    }

    private void EnviarConsulta(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            SearchingByFilter();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer stateContainer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
