#pragma checksum "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "721560aa9fc97f94c2b071eb2fc7f93ca0d56353"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddAttribute(2, "b-fn6layb08c");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href b-fn6layb08c>pruebaPelicula</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-fn6layb08c");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-fn6layb08c></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", (
#nullable restore
#line 10 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " bbcita");
            __builder.AddAttribute(12, "b-fn6layb08c");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "nav flex-column");
            __builder.AddAttribute(15, "b-fn6layb08c");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "nav-item px-3");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "b-fn6layb08c");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "<span class=\"oi\" aria-hidden=\"true\" b-fn6layb08c><img src=\"Images/startup-icon.png\" alt=\"startup-icon\" id=\"startup-icon\" b-fn6layb08c></span> Inicio\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "li");
            __builder.AddAttribute(28, "class", "nav-item px-3");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "b-fn6layb08c");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "/movies");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
                                                                 () => stateContainer.SearchingTextTyped(string.Empty)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "<span class=\"oi\" b-fn6layb08c><img src=\"Images/film-icon.png\" alt=\"film-icon\" id=\"film-icon\" b-fn6layb08c></span> Películas\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "nav-item px-3");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "b-fn6layb08c");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "nav-link");
            __builder.AddAttribute(44, "href", "/actors");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
                                                                 () => stateContainer.SearchingTextTyped(string.Empty)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "<span class=\"oi\" aria-hidden=\"true\" b-fn6layb08c><img src=\"Images/film-icon.png\" alt=\"film-icon\" id=\"film-icon\" b-fn6layb08c></span>Actores\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "li");
            __builder.AddAttribute(50, "class", "nav-item px-3");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
                                            ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "b-fn6layb08c");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "nav-link");
            __builder.AddAttribute(55, "href", "/categories");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
                                                                     () => stateContainer.SearchingTextTyped(string.Empty)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "<span class=\"oi\" b-fn6layb08c><img src=\"Images/film-icon.png\" alt=\"film-icon\" id=\"film-icon\" b-fn6layb08c></span>Categorías\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "id", "navmenu-searchbar");
            __builder.AddAttribute(62, "b-fn6layb08c");
            __builder.OpenComponent<pruebaPelicula.Client.Shared.SearchBar>(63);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\sandr\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Shared\NavMenu.razor"
       

    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateContainer stateContainer { get; set; }
    }
}
#pragma warning restore 1591
