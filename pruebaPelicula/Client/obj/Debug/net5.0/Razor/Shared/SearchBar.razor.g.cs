#pragma checksum "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d20f89f2edfc9908a9656388c418c0ba6d0dc309"
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
#line 1 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Pages.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Pages.Actors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using pruebaPelicula.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/_Imports.razor"
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
            __builder.AddAttribute(1, "class", "container-fluid div-form p-0");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "d-flex");
            __builder.AddAttribute(4, "style", "width: 100%;");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "form-control me-2 input-nav-form mr-2 FontSize");
            __builder.AddAttribute(8, "autocomplete", "off");
            __builder.AddAttribute(9, "placeholder", "Introduzca el nombre de una película, actor o categoría.");
            __builder.AddAttribute(10, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 6 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                                                                                                                 (KeyboardEventArgs e) => EnviarConsulta(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                                  film_search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film_search = __value, film_search));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n        ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "type", "button");
            __builder.AddAttribute(16, "class", "btn btn-outline-success FontSize");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                                                                                 SearchFilm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Buscar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "my-2");
            __builder.OpenElement(22, "div");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "form-check my-2");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "radio");
            __builder.AddAttribute(27, "id", "exampleRadios1");
            __builder.AddAttribute(28, "class", "form-check-input");
            __builder.AddAttribute(29, "name", "filtro");
            __builder.AddAttribute(30, "checked", 
#nullable restore
#line 13 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                                                                                                      SelectedFilter == "pelicula"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                         () => SelectedFilter = "pelicula"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n            ");
            __builder.AddMarkupContent(33, "<label for=\"exampleRadios1\" class=\"form-check-label LabelCheckboxSearch\">Película</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n        ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-check" + " my-2" + " " + (
#nullable restore
#line 17 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                                      @SelectedFilter == "pelicula" ? @EnCarteleraShow = "EnCartelera" : @EnCarteleraShow = "EnCarteleraHiden"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "type", "checkbox");
            __builder.AddAttribute(39, "id", "EnCarteleraCheckbox");
            __builder.AddAttribute(40, "class", "form-check-input");
            __builder.AddAttribute(41, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                          CheckEnCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CheckEnCartelera = __value, CheckEnCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n            ");
            __builder.AddMarkupContent(44, "<label for=\"EnCarteleraCheckbox\" class=\"form-check-label LabelCheckboxSearch\">En cartelera</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "form-check my-2");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "type", "radio");
            __builder.AddAttribute(50, "id", "exampleRadios2");
            __builder.AddAttribute(51, "class", "form-check-input");
            __builder.AddAttribute(52, "name", "filtro");
            __builder.AddAttribute(53, "checked", 
#nullable restore
#line 23 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                                                                                                  SelectedFilter == "actor"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                     () => { SelectedFilter = "actor"; CheckEnCartelera = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n        ");
            __builder.AddMarkupContent(56, "<label for=\"exampleRadios2\" class=\"form-check-label LabelCheckboxSearch\">Actor</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "form-check my-2");
            __builder.OpenElement(60, "input");
            __builder.AddAttribute(61, "type", "radio");
            __builder.AddAttribute(62, "id", "exampleRadios3");
            __builder.AddAttribute(63, "class", "form-check-input");
            __builder.AddAttribute(64, "name", "filtro");
            __builder.AddAttribute(65, "checked", 
#nullable restore
#line 28 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                                                                                                  SelectedFilter == "categoria"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
                     () => { SelectedFilter = "categoria"; CheckEnCartelera = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n        ");
            __builder.AddMarkupContent(68, "<label for=\"exampleRadios3\" class=\"form-check-label LabelCheckboxSearch\">Categoría</label>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "/Users/danielsanchez/Documents/GitHub/D2.MAS-DevTeam/pruebaPelicula/Client/Shared/SearchBar.razor"
       

    private string film_search = string.Empty;
    private string SelectedFilter = "pelicula";
    private string EnCarteleraShow = string.Empty;
    private bool CheckEnCartelera = false;

    private void SearchFilm()
    {
        if (navigationManager.Uri != "/movies/search" && SelectedFilter == "pelicula")
        {
            navigationManager.NavigateTo("/movies/search");
        }
        Console.WriteLine(film_search);
        Console.WriteLine(SelectedFilter);
    }

    private void EnviarConsulta(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            SearchFilm();
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
