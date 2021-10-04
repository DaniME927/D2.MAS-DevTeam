namespace ProyBaseMuestraII.Client.Helpers
{
    public class MultipleSelectorModel
    {
        public MultipleSelectorModel(string key, string value) 
        {
            this.Key = key;
            this.Value = value;   
        }
        
        public string Key { get; set; }
        public string Value { get; set; }
    }
}