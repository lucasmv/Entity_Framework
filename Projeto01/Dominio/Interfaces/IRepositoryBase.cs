using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Insert(TEntity obj);
        TEntity GetById(long id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
    }
}
