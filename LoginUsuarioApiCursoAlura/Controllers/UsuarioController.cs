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
        private UsuarioService _usuarioService;

        public UsuarioController(UsuarioService cadastroService)
        {
            _usuarioService = cadastroService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDTO userDTO)
        {
            await _usuarioService.Cadastrar(userDTO);
            return Ok("Cadastro realizado com sucesso");
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDTO loginUsuarioDTO) 
        {
            await _usuarioService.LoginAsync(loginUsuarioDTO);
            return Ok("Usuário Logado");
        }
    }
}
