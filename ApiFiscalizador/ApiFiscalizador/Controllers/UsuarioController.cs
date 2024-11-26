using ApiFiscalizador.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiFiscalizador.Controllers
{
    [ApiController]
    [Route("api/Usuario")]
    public class UsuarioController : ControllerBase
    {
        


       

        [HttpGet]
        [Route("ObtenerUsuarios")]
        public  List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = [];

            Usuario usuario1 = new(){
            Id = 1,
            InstitucionId = 1,
            Nombre = "Eduardo Maturana",
            Email = "ematuranacabrera@gmail.com",
            PasswordHash = "DWASDSFDFAW!",
            Activo = true,
            FechaCreacion = DateTime.Now,
            };

            Usuario usuario2 = new()
            {
                Id = 2,
                InstitucionId = 1,
                Nombre = "Ivan Contreras",
                Email = "ivancontreras@gmail.com",
                PasswordHash = "DWASDSFDFAW!",
                Activo = true,
                FechaCreacion = DateTime.Now,
            };

            usuarios.Add(usuario1);
            usuarios.Add(usuario2);

            return usuarios;
        }
    }
}
