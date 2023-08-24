using AutoMapper;
using LoginUsuarioApiCursoAlura.Data.DTOs;
using LoginUsuarioApiCursoAlura.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginUsuarioApiCursoAlura.Services
{
    public class UsuarioService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;
        private SignInManager<Usuario> _signInManager;
        private TokenService _tokenService;

        public UsuarioService(UserManager<Usuario> userManager, IMapper mapper, SignInManager<Usuario> signInManager, TokenService tokenService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }

        public async Task Cadastrar(CreateUsuarioDTO userDTO)
        {
            Usuario usuario = _mapper.Map<Usuario>(userDTO);

            IdentityResult retorno = await _userManager.CreateAsync(usuario, userDTO.Password);

            if (!retorno.Succeeded)
                 throw new ApplicationException("Falha ao cadastrar usuário");
        }

        public async Task<string> LoginAsync(LoginUsuarioDTO loginUsuarioDTO)
        {
            var resultado = await _signInManager.PasswordSignInAsync(loginUsuarioDTO.Username, 
                loginUsuarioDTO.Password, false, false);

            if (!resultado.Succeeded)
                throw new ApplicationException("Usuário não autenticado");

            var usuario = _signInManager.UserManager.Users.FirstOrDefault(
                user => user.NormalizedUserName == loginUsuarioDTO.Username.ToUpper()
                );

            var token =_tokenService.GenerateToken(usuario);

            return token;
        }
    }
}
