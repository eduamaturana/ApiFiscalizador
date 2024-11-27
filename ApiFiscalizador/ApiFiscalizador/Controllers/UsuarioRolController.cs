using ApiFiscalizador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/UsuarioRol")]
    public class UsuarioRolController: ControllerBase
    {
        

        [HttpGet]
        [Route("ObtenerRolexUsuario")]
        public List<UsuarioRol> ObtenerRolexUsuario()
        {
            List<UsuarioRol> usuarioXRol = [];

            UsuarioRol usuarioRol1 = new UsuarioRol()
            {
                UsuarioId = 1,
                RolId = 1,
                FechaAsignacion = DateTime.Now,
            };

            UsuarioRol usuarioRol2 = new UsuarioRol()
            {
                UsuarioId = 2,
                RolId = 2,
                FechaAsignacion = DateTime.Now,
            };

            usuarioXRol.Add(usuarioRol1);
            usuarioXRol.Add(usuarioRol2);


            return usuarioXRol;
        }
    }
}
