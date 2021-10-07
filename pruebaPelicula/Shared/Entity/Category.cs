using System.ComponentModel.DataAnnotations;

namespace pruebaPelicula.Shared.Entity
{
    public class Category
    {
        public Category() 
        {

        }

        public Category(int id, string name) 
        {
            this.Id = id;
            this.Name = name;   
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Name { get; set; }
    }
}