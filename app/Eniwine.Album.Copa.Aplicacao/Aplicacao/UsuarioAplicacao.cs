using Eniwine.Album.Copa.Dominio.Entidades;
using Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao;
using Eniwine.Album.Copa.Dominio.Interfaces.Repositorio;

namespace Eniwine.Album.Copa.Aplicacao.Aplicacao
{
    public class UsuarioAplicacao : AplicacaoBase<Usuario>, IUsuarioAplicacao
    {
        private IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioAplicacao(IUsuarioRepositorio usuarioRepositorio) : base(usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public Usuario Busca(string login, string senha)
        {
            return _usuarioRepositorio.Busca(login, senha);
        }
    }
}
