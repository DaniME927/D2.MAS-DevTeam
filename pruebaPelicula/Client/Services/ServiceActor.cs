using System.Diagnostics.SymbolStore;
using System;
using pruebaPelicula.Shared.Entity;
using System.Collections.Generic;

namespace pruebaPelicula.Client.Services
{
    public class ServiceActor: IServiceActor
    {
        public List<Actor> GetActors()
        {
            return new List<Actor>
            {
                new Actor(1, "Kate Winslet", 0, "12345678", 0, 5, 5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet!", "/Images/Actors/winslet.png") { BirthDate = new DateTime(1970,01,05) },
                new Actor(1, "Nicole Kidman", 0, "12345678", 0, 5, 5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet!", "/Images/Actors/kidman.png") { BirthDate = new DateTime(1970,01,05) },
                new Actor(1, "Juliane Moore", 0, "12345678", 0, 5, 5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet!", "/Images/Actors/moore.png") { BirthDate = new DateTime(1970,01,05) },
                new Actor(1, "Meryl Streep", 0, "12345678", 0, 5, 5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet!", "/Images/Actors/streep.png") { BirthDate = new DateTime(1970,01,05) },
                new Actor(1, "Collin Farell", 0, "12345678", 0, 5, 5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet!", "/Images/Actors/farell.png") { BirthDate = new DateTime(1970,01,05) },
                new Actor(1, "Ryan Gosling", 0, "12345678", 0, 5, 5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet!", "/Images/Actors/gosling.png") { BirthDate = new DateTime(1970,01,05) },
                new Actor(1, "Jake Gyllenghaal", 0, "12345678", 0, 5, 5, "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Saepe illo earum voluptatum temporibus doloremque quidem explicabo deserunt, quos, laboriosam culpa veniam aut ipsam eveniet!", "/Images/Actors/gyllenghaal.png") { BirthDate = new DateTime(1970,01,05) },
            };
        }
    }
}