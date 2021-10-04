using System;
using System.Collections.Generic;
using ProyBaseMuestraII.Shared.Entity;

namespace ProyBaseMuestraII.Client.Services
{
    public class ServiceMovie : IServiceMovie
    {
        public List<Movie> GetMovies()
        {
             return new List<Movie>
            {
                new Movie() { Name = "Shang-Chi y la leyenda de los diez anillos", EnCartelera = false, Poster = "Images/Movies/Shang-Chi y la leyenda de los diez anillos.jpg", Trailer = "https://www.youtube.com/watch?v=g4Hbz2jLxvQ", Sinopsis = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe o earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", Score = 10, Premier =  new DateTime(2021,01,05) },
                new Movie() { Name = "Spider-Man: Un nuevo universo", EnCartelera = false, Poster = "Images/Movies/SpiderMan - Un nuevo universo.png", Trailer = "https://www.youtube.com/watch?v=g4Hbz2jLxvQ", Sinopsis = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", Score = 10, Premier = new DateTime(2021,02,06) },
                new Movie() { Name = "Free Guy", EnCartelera = false, Poster = "Images/Movies/Free Guy.jpg", Trailer = "https://www.youtube.com/watch?v=g4Hbz2jLxvQ", Sinopsis = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", Score = 10, Premier = new DateTime(2021,03,07) },
                new Movie() { Name = "Interstellar", EnCartelera = false, Poster = "Images/Movies/Interstellar.jpg", Trailer = "https://www.youtube.com/watch?v=g4Hbz2jLxvQ", Sinopsis = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", Score = 10, Premier = new DateTime(2021,04,08) }, 
                new Movie() { Name = "Jungle Cruise", EnCartelera = false, Poster = "Images/Movies/Jungle Cruise.jpg", Trailer = "https://www.youtube.com/watch?v=g4Hbz2jLxvQ", Sinopsis = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet! Quia quo similique dolorem adipisci expedita.", Score = 10, Premier = new DateTime(2021,05,09) }
            };
        }        
    }
}