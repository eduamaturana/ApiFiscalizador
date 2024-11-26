using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Rol")]
    public class RolController : ControllerBase
    {
        private static readonly string[] Roles = new[]
        {
          "Administrador", "Ejecutor", "Organizacion"
        };

        [HttpGet]
        [Route("ObtenerRoles")]
        public string[] ObtenerRoles()
        {
            return Roles;
        }
    }
}
