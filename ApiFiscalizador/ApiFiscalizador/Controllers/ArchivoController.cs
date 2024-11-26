using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Archivos")]
    public class ArchivoController : ControllerBase
    {
        private static readonly string[] Archivos = new[]
        {
          "Administrador", "Ejecutor", "Organizacion"
        };

        [HttpGet]
        [Route("ObtenerArchivos")]
        public string[] ObtenerArchivos()
        {
            return Archivos;
        }
    }
}
