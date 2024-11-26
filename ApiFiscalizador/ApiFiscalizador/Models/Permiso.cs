namespace ApiFiscalizador.Models
{
    public class Permiso
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
