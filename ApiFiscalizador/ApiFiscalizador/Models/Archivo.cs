namespace ApiFiscalizador.Models
{
    public class Archivo
    {
        public int Id { get; set; }
        public int RendicionId { get; set; }
        public string? NombreArchivo { get; set; }
        public string? TipoArchivo { get; set; }
        public string? UrlArchivo { get; set; }
        public decimal Tamano { get; set; }
        public DateTime FechaCarga { get; set; }
        public string? Base64 { get; set; }
    }
}
