using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyBaseMuestraII.Shared.Entity
{
    public class Actor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string ActorName { get; set; }
        public DocumentTypeEnum DocumentType { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Document { get; set; }
        public GenderEnum Gender { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime? BirthDate { get; set; }
        public int KnowCredits { get; set; }
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