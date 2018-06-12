using System;
using System.Collections.Generic;
using System.Text;

namespace Eniwine.Album.Copa.Dominio.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
