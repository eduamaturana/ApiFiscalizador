namespace ApiFiscalizador.Models
{
    public class Rendicion
    {
        public int Id { get; set; }
        public int ProyectoId { get; set; }
        public DateTime FechaRendicion {  get; set; }
        public decimal MontoTotal { get; set; }
        public Enum? Estado {  get; set; }
        public string? Observaciones { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
