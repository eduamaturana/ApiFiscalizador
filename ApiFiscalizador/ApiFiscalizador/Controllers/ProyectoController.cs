using ApiFiscalizador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Proyecto")]
    public class ProyectoController : ControllerBase
    {

        [HttpGet]
        [Route("ObtenerProyectos")]
        public List<Proyecto> ObtenerProyectos()
        {
            List<Proyecto> proyectos = [];

            Proyecto proyecto1 = new Proyecto()
            {
                Id = 1,
                InstitucionId = 1,
                Nombre = "Vacunación y castración masiva",
                Descripcion = "Se vacunara y castrara a perros y gatos de la comuna",
                FechaInicio = DateTime.Now.AddMonths(-2),
                FechaFin = DateTime.Now.AddMonths(2),
                Presupuesto = 10000000,
                Estado = null,
                FechaCreacion = DateTime.Now,
            };

            Proyecto proyecto2 = new Proyecto()
            {
                Id = 2,
                InstitucionId = 2,
                Nombre = "Clases de tenis",
                Descripcion = "Se realizaran talleres de tenis para los niñps de la comuna",
                FechaInicio = DateTime.Now.AddMonths(-2),
                FechaFin = DateTime.Now.AddMonths(2),
                Presupuesto = 8000000,
                Estado = null,
                FechaCreacion = DateTime.Now,
            };

            proyectos.Add(proyecto1);
            proyectos.Add(proyecto2);

            return proyectos;
        }
    }
}
