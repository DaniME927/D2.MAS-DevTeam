#pragma checksum "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9be496bb69b23b2fef751d935749d1bdc164ca2b"
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
#line 1 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Actors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\_Imports.razor"
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
            __builder.AddAttribute(3, "class", "d-flex form-control p-0");
            __builder.AddAttribute(4, "style", "width: 100%; background-color: white;");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "class", "input-nav-form FontSize m-0 p-0");
            __builder.AddAttribute(8, "style", "max-height: 100%;");
            __builder.AddAttribute(9, "autocomplete", "off");
            __builder.AddAttribute(10, "placeholder", "Introduzca el nombre de una película, actor o categoría.");
            __builder.AddAttribute(11, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 6 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                                                                 (KeyboardEventArgs e) => EnviarConsulta(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                                  film_search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => film_search = __value, film_search));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        <span class=\"oi oi-magnifying-glass my-auto\" style></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "my-2");
            __builder.OpenElement(18, "div");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-check my-2");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "radio");
            __builder.AddAttribute(23, "id", "exampleRadios1");
            __builder.AddAttribute(24, "class", "form-check-input");
            __builder.AddAttribute(25, "name", "filtro");
            __builder.AddAttribute(26, "checked", 
#nullable restore
#line 13 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                                                      SelectedFilter == "pelicula"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                         () => SelectedFilter = "pelicula"

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.AddMarkupContent(29, "<label for=\"exampleRadios1\" class=\"form-check-label LabelCheckboxSearch\">Película</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-check" + " my-2" + " " + (
#nullable restore
#line 17 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                                      @SelectedFilter == "pelicula" ? @EnCarteleraShow = "EnCartelera" : @EnCarteleraShow = "EnCarteleraHiden"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                      SearchFilm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "type", "checkbox");
            __builder.AddAttribute(36, "id", "EnCarteleraCheckbox");
            __builder.AddAttribute(37, "class", "form-check-input");
            __builder.AddAttribute(38, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                          CheckEnCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CheckEnCartelera = __value, CheckEnCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<label for=\"EnCarteleraCheckbox\" class=\"form-check-label LabelCheckboxSearch\">En cartelera</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-check my-2");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "radio");
            __builder.AddAttribute(47, "id", "exampleRadios2");
            __builder.AddAttribute(48, "class", "form-check-input");
            __builder.AddAttribute(49, "name", "filtro");
            __builder.AddAttribute(50, "checked", 
#nullable restore
#line 23 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                                                  SelectedFilter == "actor"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 24 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                     () => { SelectedFilter = "actor"; CheckEnCartelera = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.AddMarkupContent(53, "<label for=\"exampleRadios2\" class=\"form-check-label LabelCheckboxSearch\">Actor</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-check my-2");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "radio");
            __builder.AddAttribute(59, "id", "exampleRadios3");
            __builder.AddAttribute(60, "class", "form-check-input");
            __builder.AddAttribute(61, "name", "filtro");
            __builder.AddAttribute(62, "checked", 
#nullable restore
#line 28 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                                                                                                  SelectedFilter == "categoria"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(63, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 29 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
                     () => { SelectedFilter = "categoria"; CheckEnCartelera = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.AddMarkupContent(65, "<label for=\"exampleRadios3\" class=\"form-check-label LabelCheckboxSearch\">Categoría</label>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\SearchBar.razor"
       

    private string film_search = string.Empty;
    private string SelectedFilter = "pelicula";
    private string EnCarteleraShow = string.Empty;
    private bool CheckEnCartelera = false;

    private void SearchFilm()
    {
        if (navigationManager.Uri != "/movies" && SelectedFilter == "pelicula")
        {
            navigationManager.NavigateTo("/movies");
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
