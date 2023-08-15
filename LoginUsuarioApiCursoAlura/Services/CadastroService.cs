using AutoMapper;
using LoginUsuarioApiCursoAlura.Data.DTOs;
using LoginUsuarioApiCursoAlura.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginUsuarioApiCursoAlura.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<Usuario> _userManager;

        public CadastroService(UserManager<Usuario> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task Cadastrar(CreateUsuarioDTO userDTO)
        {
            Usuario usuario = _mapper.Map<Usuario>(userDTO);

            IdentityResult retorno = await _userManager.CreateAsync(usuario, userDTO.Password);

            if (!retorno.Succeeded)
                 throw new ApplicationException("Falha ao cadastrar usuário");
        }
    }
}
