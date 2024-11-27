using ApiFiscalizador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/PermisoRol")]
    public class PermisoRolController : ControllerBase
    {

        [HttpGet]
        [Route("ObtenerPermisoxRol")]
        public List<RolPermiso> ObtenerPermisoxRol()
        {
            List<RolPermiso> rolesXpermiso = [];

            RolPermiso rolPermiso1 = new RolPermiso()
            {
                PermisoId = 1,
                RolId = 3,
                FechaAsignacion = DateTime.Now,
            };

            RolPermiso rolPermiso2 = new RolPermiso()
            {
                PermisoId = 2,
                RolId = 1,
                FechaAsignacion = DateTime.Now,
            };

            RolPermiso rolPermiso3 = new RolPermiso()
            {
                PermisoId = 3,
                RolId = 1,
                FechaAsignacion = DateTime.Now,
            };

            rolesXpermiso.Add(rolPermiso1);
            rolesXpermiso.Add(rolPermiso2);
            rolesXpermiso.Add(rolPermiso3);

            return rolesXpermiso;
        }
    }
}
