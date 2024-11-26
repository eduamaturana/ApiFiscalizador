using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Proyecto")]
    public class ProyectoController : ControllerBase
    {
        private static readonly string[] Proyectos = new[]
        {
          "Administrador", "Ejecutor", "Organizacion"
        };

        [HttpGet]
        [Route("ObtenerProyectos")]
        public string[] ObtenerProyectos()
        {
            return Proyectos;
        }
    }
}
