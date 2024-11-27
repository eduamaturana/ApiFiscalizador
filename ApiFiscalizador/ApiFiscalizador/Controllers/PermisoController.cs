using ApiFiscalizador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Permisos")]
    public class PermisoController : ControllerBase
    {


        [HttpGet]
        [Route("ObtenerPermisos")]
        public List<Permiso> ObtenerPermisos()
        {
            List<Permiso> permisos = [];

            Permiso permiso1 = new Permiso()
            {
                Id = 1,
                Nombre = "Otorgamiento fondos",
                Descripcion = "Aprueba entrega de fondos a proyecto",
                FechaCreacion = DateTime.Now,
            };

            Permiso permiso2 = new Permiso()
            {
                Id = 2,
                Nombre = "Crear proyecto",
                Descripcion = "Permiso para crear proyectos asociados a institucion",
                FechaCreacion = DateTime.Now,
            };

            Permiso permiso3 = new Permiso()
            {
                Id = 3,
                Nombre = "Crear institucion",
                Descripcion = "Permiso para crear y registrar instituciones",
                FechaCreacion = DateTime.Now,
            };



            permisos.Add(permiso1);

            return permisos;
        }
    }
}
