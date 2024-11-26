using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/UsuarioRol")]
    public class UsuarioRolController: ControllerBase
    {
        private static readonly string[] Roles = new[]
        {
            "Administrador", "Ejecutor", "Organizacion"
        };

        private static readonly string[] UsuarioRol = new[]
        {
            "Administrador", "Ejecutor", "Organizacion"
        };

        
        [HttpGet]
        [Route("ObtenerRoles")]
        public string[] ObtenerRoles()
        {
            return Roles;
        }

        [HttpGet]
        [Route("ObtenerRolexUsuario")]
        public string[] ObtenerRolexUsuario()
        {
            return UsuarioRol;
        }
    }
}
