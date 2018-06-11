using Eniwine.Album.Copa.Dominio.Entidades;
using Eniwine.Album.Copa.Dominio.Interfaces.Repositorio;
using System.Linq;

namespace Eniwine.Album.Copa.Repositorio.Repositorio
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        public Usuario Busca(string login, string senha)
        {
            return repo.Usuarios.Where(p => p.Login == login && p.Senha == senha).First();
        }
    }
}
