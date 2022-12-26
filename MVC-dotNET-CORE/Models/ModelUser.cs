namespace MVC_dotNET_CORE.Models
{
    public class ModelUser
    {
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public ModelUser(string nombre, int edad) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }
        public ModelUser() { }
    }
}
