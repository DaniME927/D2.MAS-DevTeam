// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace pruebaPelicula.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculasII")]
    public partial class PeliculasII : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\PeliculasII.razor"
       

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
            new Movie( 16, "Jurassic Park (Parque Jur??sico)", 1, 30, false, "Images/Movies/Jurassic Park (Parque Jur??sico).jpg",  "https://www.youtube.com/watch?v=BD77EOU8N3o", "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", 10 ) { Premier = new DateTime(2021,04,20) }
        };
    }

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "D:\Documents\GitHub\D2.MAS-DevTeam\pruebaPelicula\Client\Pages\PeliculasII.razor"
                                                 

    public List<Movie> Movies { get { return GetMovies(); } }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
    }
}
#pragma warning restore 1591
