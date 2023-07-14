﻿using Microsoft.AspNetCore.Identity;

namespace LoginUsuarioApiCursoAlura.Models
{
    public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }
        public Usuario():base() { }
    }
}
