using Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao;
using Eniwine.Album.Copa.Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eniwine.Album.Copa.Aplicacao.Aplicacao
{
    public class AplicacaoBase<TEntity> : IDisposable, IAplicacaoBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> _repositorioBase;

        public AplicacaoBase(IRepositorioBase<TEntity> repositorioBase)
        {
            _repositorioBase = repositorioBase;
        }

        public void Adiciona(TEntity entidade)
        {
            _repositorioBase.Adiciona(entidade);
        }

        public void Atualiza(TEntity entidade)
        {
            _repositorioBase.Atualiza(entidade);
        }

        public TEntity BuscaId(int id)
        {
            return _repositorioBase.BuscaId(id);
        }

        public IEnumerable<TEntity> BuscaTodos()
        {
            return _repositorioBase.BuscaTodos();
        }

        public IQueryable<TEntity> Consultar(Func<TEntity, bool> lambda)
        {
            return _repositorioBase.Consultar(lambda);
        }

        public void Dispose()
        {
            _repositorioBase.Dispose();
        }

        public void Remove(TEntity entidade)
        {
            _repositorioBase.Remove(entidade);
        }
    }
}
