using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace pruebaPelicula.Shared.Entity
{
    public class Actor
    {
        public Actor() 
        {

        }

        public Actor(int id, string actorName, DocumentTypeEnum documentType, string document, GenderEnum gender,int knownCredits, int nominations, string biography, string photo)
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
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string ActorName { get; set; }
        [Range(1, 4, ErrorMessage = "Debe seleccionar una opción.")]
        public DocumentTypeEnum DocumentType { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        public string Document { get; set; }
        [Range(1, 2, ErrorMessage = "Debe seleccionar una opción.")]
        public GenderEnum Gender { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [Range(0, 5000, ErrorMessage = "No se admiten valores negativos.")]
        public int? KnownCredits { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [Range(0, 5000, ErrorMessage = "No se admiten valores negativos.")]
        public int? Nominations { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        [StringLength(5000, MinimumLength = 500, ErrorMessage = "Este campo debe tener un mínimo de {2} carácteres y un máximo de {1} carácteres.")]
        public string Biography { get; set; }
        public string Photo { get; set; }
        [Required(ErrorMessage = "Este campo es requerido.")]
        public DateTime? BirthDate { get; set; }

        public List<MovieActor> MoviesActor { get; set; } = new List<MovieActor>();
    }

    public enum DocumentTypeEnum
    {
        Cedula = 1,
        CedulaExtranjera = 2,
        Pasaporte = 3,
        RegistroCivil = 4
    }

    public enum GenderEnum
    {
        Femenino = 1,
        Masculino = 2
    }
}