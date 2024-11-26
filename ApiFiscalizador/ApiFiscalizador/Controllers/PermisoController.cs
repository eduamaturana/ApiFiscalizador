using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Permisos")]
    public class PermisoController : ControllerBase
    {
        private static readonly string[] Permisos = new[]
        {
          "Administrador", "Ejecutor", "Organizacion"
        };

        [HttpGet]
        [Route("ObtenerPermisos")]
        public string[] ObtenerPermisos()
        {
            return Permisos;
        }
    }
}
