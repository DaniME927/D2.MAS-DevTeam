using System;
using System.Collections.Generic;
using ProyBaseMuestraII.Shared.Entity;

namespace ProyBaseMuestraII.Client.Services
{
    public class ServiceActor : IServiceActor
    {
        public List<Actor> GetActors() {
            return new List<Actor> {
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/RobertDowneyJr.jpg" },
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/DwayneJohnson.jpg" },
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/JohnnyDepp.jpg" },
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/RyanReynolds.jpg" },
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/RobertDowneyJr.jpg" },
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/DwayneJohnson.jpg" },
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/JohnnyDepp.jpg" },
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/RyanReynolds.jpg" },
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/RobertDowneyJr.jpg" },
                new Actor(){ ActorName = "Actor 1", DocumentType = DocumentTypeEnum.CedulaCiudadana, Document = "105381142", Gender = GenderEnum.Masculino, BirthDate = new DateTime(1990,12,03), KnowCredits = 12, Nominations = 3, Biography = "Biografía...", Photo = "/Images/Actors/DwayneJohnson.jpg" }
            };
        }
    }
}