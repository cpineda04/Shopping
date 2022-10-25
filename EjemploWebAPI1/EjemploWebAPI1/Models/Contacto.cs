namespace EjemploWebAPI1.Models
{
    public class Contacto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Telefono { get; set; }
        public string  Direccion { get; set; }
        public string? Email { get; set; }
        public bool Verificado { get; set; }

    }
}
