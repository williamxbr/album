using System;
using System.Collections.Generic;
using System.Text;

namespace Eniwine.Album.Copa.Dominio.Entidades
{
    public class Troca
    {
        public int TrocaId { get; set; }
        public int UsuarioIdSolicitante { get; set; }
        public int UsuarioIdRequerido { get; set; }
        public int UsuarioFigurinhaId { get; set; }
        public virtual Usuario UsuarioSolicitante { get; set; }
        public virtual Usuario UsuarioRequerido { get; set; }
        public virtual UsuarioFigurinha UsuarioFigurinha { get; set; }

    }
}
