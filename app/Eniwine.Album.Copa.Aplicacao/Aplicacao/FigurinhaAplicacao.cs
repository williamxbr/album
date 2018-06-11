using Eniwine.Album.Copa.Dominio.Entidades;
using Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao;
using Eniwine.Album.Copa.Dominio.Interfaces.Repositorio;

namespace Eniwine.Album.Copa.Aplicacao.Aplicacao
{
    public class FigurinhaAplicacao : AplicacaoBase<Figurinha>, IFigurinhaAplicacao
    {
        private readonly IFigurinhaRepositorio _figurinhaRepositorio;

        public FigurinhaAplicacao(IFigurinhaRepositorio figurinhaRepositorio) : base(figurinhaRepositorio)
        {
            _figurinhaRepositorio = figurinhaRepositorio;
        }
    }
}
