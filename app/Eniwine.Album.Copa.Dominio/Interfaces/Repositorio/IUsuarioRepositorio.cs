using Eniwine.Album.Copa.Dominio.Entidades;

namespace Eniwine.Album.Copa.Dominio.Interfaces.Repositorio
{
    public interface IUsuarioRepositorio : IRepositorioBase<Usuario>
    {
        Usuario Busca(string login, string senha);
    }
}
