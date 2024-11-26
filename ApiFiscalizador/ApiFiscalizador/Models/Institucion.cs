namespace ApiFiscalizador.Models
{
    public class Institucion
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Rut {  get; set; }
        public string? Direccion { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
