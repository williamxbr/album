using Eniwine.Album.Copa.Dominio.Entidades;
using Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao;
using Eniwine.Album.Copa.Dominio.Interfaces.Repositorio;

namespace Eniwine.Album.Copa.Aplicacao.Aplicacao
{
    public class TrocaAplicacao : AplicacaoBase<Troca>, ITrocaAplicacao
    {
        private ITrocaRepositorio _trocaRepositorio;

        public TrocaAplicacao(ITrocaRepositorio trocaRepositorio) : base(trocaRepositorio)
        {
            _trocaRepositorio = trocaRepositorio;
        }
    }
}
