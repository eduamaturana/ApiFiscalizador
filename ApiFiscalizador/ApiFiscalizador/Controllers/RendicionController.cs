using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Rendicion")]
    public class RendicionController : ControllerBase
    {
        private static readonly string[] Rendicion = new[]
        {
          "Administrador", "Ejecutor", "Organizacion"
        };

        [HttpGet]
        [Route("ObtenerRendicion")]
        public string[] ObtenerRendicion()
        {
            return Rendicion;
        }
    }
}
