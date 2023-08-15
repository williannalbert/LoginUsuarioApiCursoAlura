using AutoMapper;
using LoginUsuarioApiCursoAlura.Data.DTOs;
using LoginUsuarioApiCursoAlura.Models;
using LoginUsuarioApiCursoAlura.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LoginUsuarioApiCursoAlura.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuarioController : Controller
    {
        private CadastroService _cadastroService;

        public UsuarioController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDTO userDTO)
        {
            await _cadastroService.Cadastrar(userDTO);
            return Ok("Cadastro realizado com sucesso");
        }
    }
}
