using Eniwine.Album.Copa.Dominio.Interfaces.Repositorio;
using Eniwine.Album.Copa.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Eniwine.Album.Copa.Repositorio.Repositorio
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        protected RepositorioContexto repo = new RepositorioContexto(); 
        public void Adiciona(TEntity entidade)
        {
            repo.Set<TEntity>().Add(entidade);
            repo.SaveChanges();
        }

        public void Atualiza(TEntity entidade)
        {
            repo.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
            repo.SaveChanges();
        }

        public TEntity BuscaId(int id)
        {
            return repo.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> BuscaTodos()
        {
            return repo.Set<TEntity>().ToList();
        }

        public IQueryable<TEntity> Consultar(Func<TEntity, bool> lambda)
        {
            return repo.Set<TEntity>().Where(lambda).AsQueryable();
        }

        public void Dispose()
        {
            repo.Dispose();
        }

        public void Remove(TEntity entidade)
        {
            repo.Set<TEntity>().Remove(entidade);
            repo.SaveChanges();
        }
    }
}
