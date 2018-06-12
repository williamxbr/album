using System;
using System.Collections.Generic;
using System.Text;

namespace Eniwine.Album.Copa.Dominio.Entidades
{
    public class UsuarioFigurinha
    {
        public int UsuarioFigurinhaId { get; set; }
        public int FigurinhaId { get; set; }
        public int UsuarioId { get; set; }
        public int Quantidade { get; set; }
        public virtual Figurinha Figurinha { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
