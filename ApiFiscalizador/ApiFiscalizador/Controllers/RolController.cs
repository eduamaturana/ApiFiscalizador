using ApiFiscalizador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Rol")]
    public class RolController : ControllerBase
    {

        [HttpGet]
        [Route("ObtenerRoles")]
        public List<Rol> ObtenerRoles()
        {
            List<Rol> roles = [];

            Rol rol1 = new Rol()
            {
                Id = 1,
                Nombre = "Administrador",
                Descripcion = "Rol con todos los accesos",
                FechaCreacion = DateTime.Now,
            };

            Rol rol2 = new Rol()
            {
                Id = 2,
                Nombre = "Ejecutante",
                Descripcion = "Rol con acceso a opciones de institucion",
                FechaCreacion = DateTime.Now,
            };

            Rol rol3 = new Rol()
            {
                Id = 3,
                Nombre = "Otorgante",
                Descripcion = "Rol con acceso a opciones de la municipalidad",
                FechaCreacion = DateTime.Now,
            };


            roles.Add(rol1);
            roles.Add(rol2);
            roles.Add(rol3);

            return roles;
        }
    }
}
