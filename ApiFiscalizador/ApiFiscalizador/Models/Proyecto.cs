namespace ApiFiscalizador.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public int InstitucionId { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal Presupuesto { get; set; }
        public Enum? Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
