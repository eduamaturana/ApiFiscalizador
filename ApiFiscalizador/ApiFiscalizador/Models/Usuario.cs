namespace ApiFiscalizador.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public int InstitucionId { get; set; }
        public string? Nombre { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
