using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eniwine.Album.Copa.Dominio.Interfaces.Aplicacao
{
    public interface IAplicacaoBase<TEntity> where TEntity : class
    {
        void Adiciona(TEntity entidade);
        TEntity BuscaId(int id);
        IEnumerable<TEntity> BuscaTodos();
        IQueryable<TEntity> Consultar(Func<TEntity, bool> lambda);
        void Atualiza(TEntity entidade);
        void Remove(TEntity entidade);
        void Dispose();
    }
}
