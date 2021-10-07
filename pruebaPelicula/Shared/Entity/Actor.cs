using System;
using System.ComponentModel.DataAnnotations;

namespace pruebaPelicula.Shared.Entity
{
    public class Actor
    {
        public Actor() 
        {

        }

        public Actor(int id, string actorName, DocumentTypeEnum documentType, string document, GenderEnum gender, int knownCredits, int nominations, string biography, string photo) 
        {
            this.Id = id;
            this.ActorName = actorName;
            this.DocumentType = documentType;
            this.Document = document;
            this.Gender = gender;
            this.KnownCredits = knownCredits;
            this.Nominations = nominations;
            this.Biography = biography;
            this.Photo = photo; 
        }
        
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string ActorName { get; set; }
        public DocumentTypeEnum DocumentType { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Document { get; set; }
        public GenderEnum Gender { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime? BirthDate { get; set; }
        public int KnownCredits { get; set; }
        public int Nominations { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Biography { get; set; }
        public string Photo { get; set; }
    }

    public enum DocumentTypeEnum
    {
        CedulaCiudadana = 0,
        CedulaExtranjera = 1,
        Pasaporte = 2,
        RegistroCivil = 3
    }

    public enum GenderEnum
    {
        Femenino = 0,
        Masculino = 1
    }
}