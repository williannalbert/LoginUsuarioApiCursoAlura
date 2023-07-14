using AutoMapper;
using LoginUsuarioApiCursoAlura.Data.DTOs;
using LoginUsuarioApiCursoAlura.Models;

namespace LoginUsuarioApiCursoAlura.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDTO, Usuario>();
        }
    }
}
