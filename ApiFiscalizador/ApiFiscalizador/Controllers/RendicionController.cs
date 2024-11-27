using ApiFiscalizador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Rendicion")]
    public class RendicionController : ControllerBase
    {
       
        [HttpGet]
        [Route("ObtenerRendicion")]
        public List<Rendicion> ObtenerRendicion()
        {
            List<Rendicion> rendiciones = [];

            Rendicion rendicion1 = new Rendicion()
            {
                Id = 1,
                ProyectoId = 1,
                FechaRendicion = DateTime.Now,
                MontoTotal = 500000,
                Estado = null,
                Observaciones = "Compra de vacunas antirrabica",
                FechaCreacion = DateTime.Now,
            };

            Rendicion rendicion2 = new Rendicion()
            {
                Id = 2,
                ProyectoId = 2,
                FechaRendicion = DateTime.Now,
                MontoTotal = 1000000,
                Estado = null,
                Observaciones = "Arriendo de canchas",
                FechaCreacion = DateTime.Now,
            };

            rendiciones.Add(rendicion1);
            rendiciones.Add(rendicion2);

            return rendiciones;
        }
    }
}
