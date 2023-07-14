using LoginUsuarioApiCursoAlura.Data.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace LoginUsuarioApiCursoAlura.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class UsuarioController : Controller
    {
        [HttpPost]
        public IActionResult CadastrarUsuario(CreateUsuarioDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
