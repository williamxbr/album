using Eniwine.Album.Copa.Dominio.Entidades;

namespace Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao
{
    public interface IUsuarioAplicacao : IAplicacaoBase<Usuario>
    {
        Usuario Busca(string login, string senha);
    }
}
