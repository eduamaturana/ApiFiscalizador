using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Institucion")]
    public class InstitucionController : ControllerBase
    {
        private static readonly string[] Instituciones = new[]
        {
          "Administrador", "Ejecutor", "Organizacion"
        };

        [HttpGet]
        [Route("ObtenerInstituciones")]
        public string[] ObtenerInstituciones()
        {
            return Instituciones;
        }
    }
}
