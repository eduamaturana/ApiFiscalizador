using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/PermisoRol")]
    public class PermisoRolController : ControllerBase
    {
        private static readonly string[] PermisoRol = new[]
       {
          "Administrador", "Ejecutor", "Organizacion"
        };

        [HttpGet]
        [Route("ObtenerPermisoxRol")]
        public string[] ObtenerPermisoxRol()
        {
            return PermisoRol;
        }
    }
}
