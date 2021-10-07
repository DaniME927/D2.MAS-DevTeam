namespace pruebaPelicula.Client.Helpers
{
    public class MultipleSelectorModel
    {
        public MultipleSelectorModel() 
        {

        }

        public MultipleSelectorModel(string id, string name) 
        {
            this.Id = id;
            this.Name = name;   
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}