using Eniwine.Album.Copa.Dominio.Entidades;

namespace Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao
{
    public interface ITrocaAplicacao : IAplicacaoBase<Troca>
    {
        void solicitar(Troca troca);
        void aceitar(Troca troca);
        void recusar(Troca troca);
    }
}
