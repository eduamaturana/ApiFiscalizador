using ApiFiscalizador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Institucion")]
    public class InstitucionController : ControllerBase
    {

        [HttpGet]
        [Route("ObtenerInstituciones")]
        public List<Institucion> ObtenerInstituciones()
        {
            List<Institucion> instituciones = [];

            Institucion institucion1 = new Institucion()
            {
                Id = 1,
                Nombre = "Fundacion adopta un perrito",
                Rut = "69344195-7",
                Direccion = "General Balmaceda 34 Depto 12 , Santiago",
                Activo = true,
                FechaCreacion = DateTime.Now,
            };

            Institucion institucion2 = new Institucion()
            {
                Id = 2,
                Nombre = "ONG del deporte",
                Rut = "77357241-3",
                Direccion = "Calle fuerte Pacheco 2221 oficina 601 , Santiago",
                Activo = true,
                FechaCreacion = DateTime.Now,
            };

            instituciones.Add(institucion1);  
            instituciones.Add(institucion2);


            return instituciones;
        }
    }
}
