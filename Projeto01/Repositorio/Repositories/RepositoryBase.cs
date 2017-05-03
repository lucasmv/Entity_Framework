using Dominio.Interfaces;
using Repositorio.Contexto;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repositorio.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected Context m_Context = null;

        protected DbSet<TEntity> m_DbSet;

        public RepositoryBase()
        {
            m_Context = new Context();
            m_DbSet = m_Context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            //Desativa Lazy Loading
            //m_Context.Configuration.ProxyCreationEnabled = false;
            return m_DbSet.AsEnumerable();
        }

        public TEntity GetById(long id)
        {
            return m_DbSet.Find(id);
        }

        public virtual void Insert(TEntity obj)
        {
            m_DbSet.Add(obj);
            m_Context.SaveChanges();
        }

        public void Remove(TEntity obj)
        {
            m_DbSet.Remove(obj);
            m_Context.SaveChanges();
        }

        public virtual void Update(TEntity obj)
        {
            m_Context.Entry(obj).State = EntityState.Modified;
            m_Context.SaveChanges();
        }

    }
}
