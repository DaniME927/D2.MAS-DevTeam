#pragma checksum "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2b69959e8a45857eddc954f81602bfd97d5df58"
// <auto-generated/>
#pragma warning disable 1591
namespace pruebaPelicula.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Pages.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using pruebaPelicula.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculasII")]
    public partial class PeliculasII : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card-deck d-flex justify-content-center mx-auto");
            __builder.AddAttribute(2, "id", "card-deck");
#nullable restore
#line 7 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
     foreach (var movie in Movies)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card d-flex align-items-center my-3 p-1");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-img-info");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 12 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
                           movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "class", "card-img-top");
            __builder.AddAttribute(10, "alt", 
#nullable restore
#line 12 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
                                                                    movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-info");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "style", "color: white;");
            __builder.AddContent(16, 
#nullable restore
#line 14 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
                                              movie.Sinopsis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row mb-3 m-0 d-flex justify-content-end");
            __builder.AddAttribute(20, "id", "container-rate-description");
            __builder.AddMarkupContent(21, "<span class=\"mr-2\"><img src=\"Images/Movies/star.png\" id=\"icon-star-description\"></span>\r\n                        ");
            __builder.OpenElement(22, "em");
            __builder.OpenElement(23, "h4");
            __builder.AddAttribute(24, "class", "m-0 p-0");
            __builder.AddAttribute(25, "id", "rate-description");
            __builder.AddContent(26, 
#nullable restore
#line 19 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
                                                                       movie.Score

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(27, " /10");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "card-body");
            __builder.OpenElement(31, "h5");
            __builder.AddAttribute(32, "class", "card-title");
            __builder.AddContent(33, 
#nullable restore
#line 24 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
                                        movie.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "a-group");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "href", 
#nullable restore
#line 26 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
                              movie.Trailer

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "target", "_blank");
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddContent(41, "Ver trailer");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "class", "btn btn-link");
            __builder.AddAttribute(45, "id", "btn-details");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
                                                                         ()=>modal.Show<ModalInformacionPelicula>("Información adicional")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Detalles");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n");
            __builder.AddMarkupContent(49, @"<div class=""d-flex justify-content-center""><nav aria-label=""pagination-nav""><ul class=""pagination""><li class=""page-item disabled""><span class=""page-link"">Previous</span></li>
            <li class=""page-item active""><span class=""page-link"">
                    1
                    <span class=""sr-only"">(current)</span></span></li>
            <li class=""page-item""><a class=""page-link"" href=""peliculas2"">2</a></li>
            <li class=""page-item""><a class=""page-link"" href=""peliculas2"">3</a></li>
            <li class=""page-item""><a class=""page-link"" href=""peliculas2"">Next</a></li></ul></nav></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
       

    private List<Movie> GetMovies()
    {
        return new List<Movie>
        {
            new Movie( 1, "Shang-Chi y la leyenda de los diez anillos", 1, 30, false, "Images/Movies/Shang-Chi y la leyenda de los diez anillos.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 10 ) { Premier = new DateTime(2021,01,05) },
            new Movie( 2, "Spider-Man: Un nuevo universo", 1, 30, false, "Images/Movies/SpiderMan - Un nuevo universo.png",  "https://www.youtube.com/watch?v=-RSseKOWpEQ", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 10 ) { Premier = new DateTime(2021,02,06) },
            new Movie( 3, "Free Guy", 1, 30, false, "Images/Movies/Free Guy.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 10 ) { Premier = new DateTime(2021,03,07) },
            new Movie( 4, "Interstellar", 1, 30, false, "Images/Movies/Interstellar.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 9 ) { Premier = new DateTime(2021,04,08) },
            new Movie( 5, "Jungle Cruise", 1, 30, false, "Images/Movies/Jungle Cruise.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 8 ) { Premier = new DateTime(2021,05,09) },
            new Movie( 6, "Fast & Furious 9", 1, 30, false, "Images/Movies/Fast & Furious 9.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 7 ) { Premier = new DateTime(2021,06,10) },
            new Movie( 7, "Origen", 1, 30, false, "Images/Movies/Origen.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 8 ) { Premier = new DateTime(2021,07,11) },
            new Movie( 8, "Forrest Gump", 1, 30, false, "Images/Movies/Forrest Gump.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 9 ) { Premier = new DateTime(2021,08,12) },
            new Movie( 9, "Your Name.", 1, 30, false, "Images/Movies/Your Name.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 10 ) { Premier = new DateTime(2021,09,13) },
            new Movie( 10, "El padrino", 1, 30, false, "Images/Movies/El padrino.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 7 ) { Premier = new DateTime(2021,10,14) },
            new Movie( 11, "Joker", 1, 30, false, "Images/Movies/Joker.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 9 ) { Premier = new DateTime(2021,11,15) },
            new Movie( 12, "Malditos bastardos", 1, 30, false, "Images/Movies/Malditos bastardos.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 7 ) { Premier = new DateTime(2021,12,16) },
            new Movie( 13, "Vengadores: Endgame", 1, 30, false, "Images/Movies/Vengadores - Endgame.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 10 ) { Premier = new DateTime(2021,01,17) },
            new Movie( 14, "La familia Bigfoot", 1, 30, false, "Images/Movies/La familia Bigfoot.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 6 ) { Premier = new DateTime(2021,02,18) },
            new Movie( 15, "El hombre elefante", 1, 30, false, "Images/Movies/El hombre elefante.jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 8 ) { Premier = new DateTime(2021,03,19) },
            new Movie( 16, "Jurassic Park (Parque Jurásico)", 1, 30, false, "Images/Movies/Jurassic Park (Parque Jurásico).jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 10 ) { Premier = new DateTime(2021,04,20) }
        };
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\sandr\Desktop\Proyectos v.2\pruebaPelicula\Client\Pages\PeliculasII.razor"
                                                 

    public List<Movie> Movies { get { return GetMovies(); } }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
    }
}
#pragma warning restore 1591