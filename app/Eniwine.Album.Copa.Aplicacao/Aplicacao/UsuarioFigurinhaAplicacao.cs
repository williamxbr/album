using Eniwine.Album.Copa.Dominio.Entidades;
using Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao;
using Eniwine.Album.Copa.Dominio.Interfaces.Repositorio;

namespace Eniwine.Album.Copa.Aplicacao.Aplicacao
{
    public class UsuarioFigurinhaAplicacao : AplicacaoBase<UsuarioFigurinha>, IUsuarioFigurinhaAplicacao
    {
        private readonly IUsuarioFigurinhaRepositorio _usuarioFigurinhaRepositorio;

        public UsuarioFigurinhaAplicacao(IUsuarioFigurinhaRepositorio usuarioFigurinhaRepositorio) : base(usuarioFigurinhaRepositorio)
        {
            _usuarioFigurinhaRepositorio = usuarioFigurinhaRepositorio;
        }

     
    }
}
