using ApiFiscalizador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Archivos")]
    public class ArchivoController : ControllerBase
    {

        [HttpGet]
        [Route("ObtenerArchivos")]
        public List<Archivo> ObtenerArchivos()
        {
            List<Archivo> archivos = [];

            Archivo archivo1 = new Archivo()
            {
                Id = 1,
                RendicionId = 1,
                NombreArchivo = "boleta.pdf",
                TipoArchivo = "boleta",
                UrlArchivo = "",
                Tamano = 1064,
                FechaCarga = DateTime.Now,
                Base64 = "",
            };

            Archivo archivo2 = new Archivo()
            {
                Id = 2,
                RendicionId = 2,
                NombreArchivo = "facturapago.pdf",
                TipoArchivo = "factura",
                UrlArchivo = "",
                Tamano = 1064,
                FechaCarga = DateTime.Now,
                Base64 = "",
            };

            archivos.Add(archivo1);
            archivos.Add(archivo2);

            return archivos;
        }
    }
}
